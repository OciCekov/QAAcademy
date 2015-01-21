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
        //[TestCase(295)]
        public void Feedback_ConfirmErrorLengthOfMessageExist()
        {
            string message = "blabla";
            string errorMessage = "Моля напишете поне 20 символа";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message);
            Pages<FeedbackPage>.Instance.Validator.AssertErrorLengthOfMessage(errorMessage);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(413)]
        public void Feedback_ConfirmErrorBlankMessageExist()
        {
            string message = "";
            string errorMessage = "Моля попълнете полето.";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message);
            Pages<FeedbackPage>.Instance.Validator.AssertErrorLengthOfMessage(errorMessage);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(414)]
        public void Feedback_ConfirmErrorMessageExistWhenWhiteSpacesEntered()
        {
            string message = "                         ";
            string errorMessage = "Моля попълнете полето.";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message);
            Pages<FeedbackPage>.Instance.Validator.AssertErrorLengthOfMessage(errorMessage);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(415)]
        public void Feedback_ConfirmSendNewMessageNavigatesCorrectly()
        {
            string message = "<html><body></body></html>";
            string sendNewMessage = "Изпратете друго съобщение";
            string feedbackUrl = "http://test.telerikacademy.com/FeedbackReport";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message); // TODO: In order not to have too many similar messages, no delete button
            Pages<FeedbackPage>.Instance.Validator.AssertSendNewMessageExists(sendNewMessage);
            Pages<FeedbackPage>.Instance.NavigateToSendNewMessage();
            Pages<FeedbackPage>.Instance.Validator.AssertNavigatesCorrectly(feedbackUrl);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(416)]
        public void Feedback_ConfirmGoToHomeNavigatesCorrectly()
        {
            string message = "&#x31;&#x27;&#x20;&#x4F;&#x52;&#x20;&#x27;&#x31;&#x27;&#x3D;&#x27;&#x31;";
            string goHomeMessage = "Обратно към началната страница";
            string homePageUrl = "http://test.telerikacademy.com/";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message); // TODO: In order not to have too many similar messages, no delete button
            Pages<FeedbackPage>.Instance.Validator.AssertGoHomeMessageExists(goHomeMessage);
            Pages<FeedbackPage>.Instance.NavigateToHomePage();
            Pages<FeedbackPage>.Instance.Validator.AssertNavigatesCorrectly(homePageUrl);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(296)]
        public void Feedback_ConfirmFeedbackReportExist()
        {
            string message = "Message should be at least 20 symbols";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(message); // TODO: In order not to have too many similar messages, no delete button
            Pages<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertMessagePresent(message);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(2)]
        //[TestCase(297)]
        public void Feedback_ConfirmFeedbackReportIsResolved()
        {
            string statusTrue = "true";
            string statusFalse = "false";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            Pages<FeedbackPage>.Instance.ResolveFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertStatus(statusTrue);
            Pages<FeedbackPage>.Instance.ResolveFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertStatus(statusFalse);
        }
    }
}
