namespace TelerikSystem.Tests.Admin.BasicModules.Feedback
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Feedback;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class FeedbackTests : BaseTest
    {
        private User currentUser;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        public void Feedback_ConfirmErrorLengthOfMessageExist()
        {
            string message = "blabla";
            string errorMessage = "Моля напишете поне 20 символа";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FeedbackPage>.Instance.CreateFeedbackReport(message);
            BaseInstance<FeedbackPage>.Instance.Validator.AssertErrorLengthOfMessage(errorMessage);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        public void Feedback_ConfirmFeedbackReportExist()
        {
            string message = "Message should be at least 20 symbols";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FeedbackPage>.Instance.CreateFeedbackReport(message); // TODO: In order not to have too many similar messages, no delete button
            BaseInstance<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            BaseInstance<FeedbackPage>.Instance.Validator.AssertMessagePresent(message);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        public void Feedback_ConfirmFeedbackReportIsResolved()
        {
            string statusTrue = "true";
            string statusFalse = "false";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            BaseInstance<FeedbackPage>.Instance.ResolveFeedbackReport();
            BaseInstance<FeedbackPage>.Instance.Validator.AssertStatus(statusTrue);
            BaseInstance<FeedbackPage>.Instance.ResolveFeedbackReport();
            BaseInstance<FeedbackPage>.Instance.Validator.AssertStatus(statusFalse);
        }
    }
}
