namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class NewExamPageValidator
    {
        public void AssertTitleIsVisible()
        {
            var newExamPage = BaseInstance<NewExamPage>.Instance;
         //   newExamPage.Navigate();
            Assert.IsTrue(newExamPage.Map.WindowTitle.IsVisible());
        }
    }
}