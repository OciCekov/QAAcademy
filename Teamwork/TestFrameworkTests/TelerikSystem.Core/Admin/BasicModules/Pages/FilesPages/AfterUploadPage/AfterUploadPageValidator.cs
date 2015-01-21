namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage
{
    using ArtOfTest.Common.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage;
    using TestingFramework.Core.Base;

    public class AfterUploadPageValidator
    {
        public void AssertFileIsUploadedMsgAppears()
        {
            Assert.IsTrue(BaseInstance<AfterUploadPage>.Instance.Map.MainSection.InnerText.Contains("Файлът е качен успешно"));
            if (BaseInstance<AfterUploadPage>.Instance.Map.MainSection.InnerText.Contains("Файлът е качен успешно"))
            {
                BaseInstance<FilesPage>.Instance.DeleteLastFileUploaded();
            }
        }
    }
}