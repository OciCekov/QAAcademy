namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using TestingFramework.Core.Base;

    public class FeedbackPageValidator
    {
        public void AssertErrorLengthOfMessage(string actual)
        {
            string expected = Pages<FeedbackPage>.Instance.Map.ErrorLengthOfMessage.InnerText;
            Assert.AreEqual(expected, actual);
        }

        public void AssertMessagePresent(string message)
        {
            Assert.IsTrue(Pages<FeedbackPage>.Instance.IsMessagePresent(message));
        }

        public void AssertStatus(string status)
        {
            Assert.IsTrue(Pages<FeedbackPage>.Instance.IsStatusTrue(status));
        }

        public void AssertSendNewMessageExists(string actual)
        {
            string expected = Pages<FeedbackPage>.Instance.Map.SuccesMessageSendNew.InnerText;
            Assert.AreEqual(expected, actual);
        }

        public void AssertNavigatesCorrectly(string actual)
        {
            var expected = Manager.Current.ActiveBrowser.Url.ToString();
            Assert.AreEqual(expected, actual);
        }

        public void AssertGoHomeMessageExists(string actual)
        {
            string expected = Pages<FeedbackPage>.Instance.Map.SuccesMessageBackToHome.InnerText;
            Assert.AreEqual(expected, actual);
        }
    }
}