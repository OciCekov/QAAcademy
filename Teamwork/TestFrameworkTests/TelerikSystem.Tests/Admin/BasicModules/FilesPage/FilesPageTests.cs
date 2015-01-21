namespace TelerikSystem.Tests.Admin.BasicModules.FilesPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.AfterUploadPage;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage;
    using TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.UploadFilesPage;
    using TelerikSystem.Core.Admin.Pages.ModulesPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.Pages.MainPage;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class FilesPageTests : BaseTest
    {
        private const string DocFileName = "test.docx";
        private const string JpgFileName = "test.jpg";
        private const string DllFileName = "test.dll";
        private const string ExeFileName = "test.exe";
        private const string JsFileName = "test.js";
        private const string Mp4FileName = "test.mp4";
        private const string PptFileName = "test.ppt";
        private const string PdfFileName = "test.pdf";
        private const string XlsFileName = "test.xls";
        private const string RarFileName = "test.rar";
        private const string ZipFileName = "test.zip";
        private const string InvalidFileName = "invalid";

        private User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void FilesUpload_UploadDocMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(DocFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadDocIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(DocFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadJpgMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(JpgFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadJpgIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(JpgFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadDllMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(DllFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadDllIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(DllFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadExeMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(ExeFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadExeIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(ExeFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadJsMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(JsFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadJsIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(JsFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadMp4MessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(Mp4FileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadMp4IsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(Mp4FileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadPptMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(PptFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadPptIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(PptFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadPdfMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(PdfFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadPdfIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(PdfFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadXlsMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(XlsFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadXlsIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(XlsFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadRarMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(RarFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadRarIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(RarFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_UploadZipMessageAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(ZipFileName, "random description");
            BaseInstance<AfterUploadPage>.Instance.Validator.AssertFileIsUploadedMsgAppears();
        }

        [TestMethod]
        public void FilesUpload_UploadZipIsPresent()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(ZipFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertUploadedFileIsPresentByHashedName();
        }

        [TestMethod]
        public void FilesUpload_CanNavigateToFilesUploadPage()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<MainPage>.Instance.Map.Admin.Click();
            BaseInstance<ModulesPage>.Instance.Map.FilesUploadModule.Click();
            BaseInstance<FilesPage>.Instance.Validator.AssertIsOnFileUploadPage();
        }

        [TestMethod]
        public void FilesUpload_PickFileRequiredAppears()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FilesPage>.Instance.UploadFile();
            BaseInstance<UploadFilesPage>.Instance.UploadFile(null, "random description");
            BaseInstance<UploadFilesPage>.Instance.Validator.AssertPickFileRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_DescriptionRequiredAppears()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FilesPage>.Instance.UploadFile();
            BaseInstance<UploadFilesPage>.Instance.UploadFile(DocFileName, null);
            BaseInstance<UploadFilesPage>.Instance.Validator.AssertDescriptionRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_RequiredMessagesAppers()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FilesPage>.Instance.UploadFile();
            BaseInstance<UploadFilesPage>.Instance.UploadFile(null, null);
            BaseInstance<UploadFilesPage>.Instance.Validator.AssertDescriptionRequiredMsgAppers();
            BaseInstance<UploadFilesPage>.Instance.Validator.AssertPickFileRequiredMsgAppers();
        }

        [TestMethod]
        public void FilesUpload_InvalidFormatNotUploaded()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<UploadFilesPage>.Instance.UploadFile(InvalidFileName, "random description");
            BaseInstance<FilesPage>.Instance.Validator.AssertFileNotPresentByOriginalName(InvalidFileName);
        }

        [TestMethod]
        public void KendoTest()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<FilesPage>.Instance.Navigate();
        }
    }
}
