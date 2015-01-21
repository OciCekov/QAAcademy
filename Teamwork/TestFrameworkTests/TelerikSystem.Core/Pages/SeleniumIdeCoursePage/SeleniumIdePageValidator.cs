namespace TelerikSystem.Core.Pages.SeleniumIdeCoursePage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class SeleniumIdePageValidator
    {
        public void AssertUnenrollmentActive()
        {
            BaseInstance<SeleniumIdePage>.Instance.Navigate();
            Assert.IsTrue(BaseInstance<SeleniumIdePage>.Instance.Map.UnenrollButton.InnerText.Contains("Отпишете курса")); 
        }

        public void AssertUnenrollmentNotActive()
        {
            BaseInstance<SeleniumIdePage>.Instance.Navigate();
            Assert.IsTrue(BaseInstance<SeleniumIdePage>.Instance.Map.UnenrollmentNotActiveMessage.InnerText.Contains("Отписването от курса не е активно"));
        }
    }
}