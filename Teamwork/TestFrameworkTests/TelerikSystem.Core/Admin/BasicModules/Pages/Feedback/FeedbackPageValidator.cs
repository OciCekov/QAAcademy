namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class FeedbackPageValidator
    {
        public void AssertErrorLengthOfMessage(string actual)
        {
            string expected = BaseInstance<FeedbackPage>.Instance.Map.ErrorLengthOfMessage.InnerText;
            Assert.AreEqual(expected, actual);
        }

        public void AssertMessagePresent(string message)
        {
            Assert.IsTrue(BaseInstance<FeedbackPage>.Instance.IsMessagePresent(message));
        }

        public void AssertStatus(string status)
        {
            Assert.IsTrue(BaseInstance<FeedbackPage>.Instance.IsStatusTrue(status));
        }
    }
}