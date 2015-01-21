namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.UploadFilesPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class UploadFilesPageValidator
    {
        public void AssertDescriptionRequiredMsgAppers()
        {
            Assert.IsTrue(BaseInstance<UploadFilesPage>.Instance.Map.ValidationProblemsList.InnerText.Contains("Моля посочете описание на файла"));
        }

        public void AssertPickFileRequiredMsgAppers()
        {
            Assert.IsTrue(BaseInstance<UploadFilesPage>.Instance.Map.ValidationProblemsList.InnerText.Contains("Моля изберете файл"));
        }
    }
}