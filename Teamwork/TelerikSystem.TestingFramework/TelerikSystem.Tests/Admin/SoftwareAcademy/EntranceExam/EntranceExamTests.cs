namespace TelerikSystem.Tests.Admin.SoftwareAcademy.EntranceExam
{
    using System;
    using System.Globalization;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.EditExamPage;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class EntranceExamTests : BaseTest
    {
        private string startDate;
        private string endDate;
        private User currentUser;
        private int examsCount;
        private int examsCountAfterDelete;
        private string dateFormat = "dd/MM/yyyy hh:mm:ss";
        private string iqConfiguration = "IQ Test (Разни въпроси)";
        private string itConfiguration = "IT test (Разни въпроси)";
        private string englishConfiguration = "English Test (Разни въпроси)";
        private string hallOption = "Enterprise";
        private string studentsCount = "43";

        [TestInitialize]
        public override void TestInit()
        {
            currentUser = GetUser.Admin();
            startDate = DateTime.Now.AddDays(2)
                .ToString(dateFormat, CultureInfo.InvariantCulture);
            endDate = DateTime.Now.AddDays(2)
                .AddMinutes(2)
                .ToString(dateFormat, CultureInfo.InvariantCulture);
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CreateNewExam()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<EntranceExamPage>.Instance.Navigate();
            examsCount = Pages<EntranceExamPage>.Instance.GetExamCount();
            Pages<NewExamPage>.Instance.Navigate();
            Pages<NewExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<NewExamPage>.Instance.CreateNewExam(startDate, endDate);
            Pages<EntranceExamPage>.Instance.Validator.AssertExamIsAdded(examsCount);
            Pages<EntranceExamPage>.Instance.RemoveLatestExam();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(3)]
        public void EntranceExam_RemoveExam()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<EntranceExamPage>.Instance.Navigate();
            examsCount = Pages<EntranceExamPage>.Instance.GetExamCount();
            Pages<NewExamPage>.Instance.Navigate();
            Pages<NewExamPage>.Instance.CreateNewExam(startDate, endDate);
            Pages<EntranceExamPage>.Instance.Validator.AssertExamIsAdded(examsCount);
            examsCountAfterDelete = Pages<EntranceExamPage>.Instance.GetExamCount();
            Pages<EntranceExamPage>.Instance.RemoveLatestExam();
            Pages<EntranceExamPage>.Instance.Browser.RefreshDomTree();
            Pages<EntranceExamPage>.Instance.Validator.AssetExamIsRemoved(examsCountAfterDelete);
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectExamDateIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            // This should either be here, or we have to guarantee that the first test will have to run before this one
            Pages<NewExamPage>.Instance.Navigate();
            Pages<NewExamPage>.Instance.CreateNewExam(startDate, endDate);
            string dateFromTable = Pages<EntranceExamPage>.Instance.GetsLastExamStartTime(dateFormat);
            Pages<EntranceExamPage>.Instance.Validator.AssertStartDatesMatch(startDate, dateFromTable);
            Pages<EntranceExamPage>.Instance.RemoveLatestExam();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectIqConfigurationIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            
            Pages<NewExamPage>.Instance.Navigate();
            Pages<NewExamPage>.Instance.CreateNewExam(startDate, endDate, iqConfiguration, itConfiguration, englishConfiguration, studentsCount, hallOption);
            Pages<EditExamPage>.Instance.Navigate();
            Pages<EditExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<EditExamPage>.Instance.Validator.AssertIqConfiguration(iqConfiguration);
            Pages<EditExamPage>.Instance.Map.CancelButton.Click();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectItConfigurationIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
          
            Pages<EditExamPage>.Instance.Navigate();
            Pages<EditExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<EditExamPage>.Instance.Validator.AssertItConfiguration(itConfiguration);
            Pages<EditExamPage>.Instance.Map.CancelButton.Click();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectEnglishConfigurationIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<EditExamPage>.Instance.Navigate();
            Pages<EditExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<EditExamPage>.Instance.Validator.AssertEnglishConfiguration(englishConfiguration);
            Pages<EditExamPage>.Instance.Map.CancelButton.Click();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectHallOptionIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<EditExamPage>.Instance.Navigate();
            Pages<EditExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<EditExamPage>.Instance.Validator.AssertHallOption(hallOption);
            Pages<EditExamPage>.Instance.Map.CancelButton.Click();
        }

        [TestMethod]
        [Owner("Oci Cekov")]
        [Priority(1)]
        public void EntranceExam_CorrectStudentsLimitIsSet()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<EditExamPage>.Instance.Navigate();
            Pages<EditExamPage>.Instance.Validator.AssertTitleIsVisible();
            Pages<EditExamPage>.Instance.Validator.AssertStudentsCount(studentsCount);
            Pages<EditExamPage>.Instance.Map.CancelButton.Click();
        }
    }
}