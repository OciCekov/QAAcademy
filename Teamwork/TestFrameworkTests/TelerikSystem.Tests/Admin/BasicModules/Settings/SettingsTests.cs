namespace TelerikSystem.Tests.Admin.BasicModules.Settings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage;
    using TelerikSystem.Core.Admin.Pages.ModulesPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.Pages.MainPage;
    using TelerikSystem.Core.Pages.SeleniumIdeCoursePage;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class SettingsTests : BaseTest
    {
        private User currentUser;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void Setting_CanCreateAndModifyNewSetting()
        {
            const string SettingName = "TestSetting";
            const string SettingValue = "SettingValue";
            const string NewSettingName = "NewTestSetting";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.CreateNewSetting(SettingName, SettingValue);
            BaseInstance<SettingsPage>.Instance.Validator.AssertSettingPresent(SettingName);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, NewSettingName);
            BaseInstance<SettingsPage>.Instance.Validator.AssertSettingPresent(NewSettingName);
            BaseInstance<SettingsPage>.Instance.Validator.AssertCanDeleteSetting(NewSettingName);
        }

        [TestMethod]
        public void Setting_NewSettingFieldsAreRequired()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.Navigate();
            BaseInstance<SettingsPage>.Instance.Validator.AssertNewSettingFieldsAreRequired();
        }

        [TestMethod]
        public void Settings_AdminSettingsButtonsExist()
        {
            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<MainPage>.Instance.Validator.AssertAdminIsVisible();
            BaseInstance<MainPage>.Instance.Map.Admin.Click();
            BaseInstance<ModulesPage>.Instance.Validator.AssertSettingsModuleExists();
            BaseInstance<ModulesPage>.Instance.Map.SettingsModule.Click();
            BaseInstance<SettingsPage>.Instance.Validator.AssertNewSettingButtonIsVisible();
        }

        [TestMethod]
        public void Settings_DoesSoftwareAcademyCandidateFormOpenedFunctionsCorrectly()
        {
            const string SettingName = "IsSoftwareAcademyCandidateFormOpened";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "false");
            BaseInstance<ApplySofAcademyPage>.Instance.Navigate();
            BaseInstance<ApplySofAcademyPage>.Instance.Validator.AssertIsNotInCandidatePeriod();
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "true");
            BaseInstance<ApplySofAcademyPage>.Instance.Navigate();
            BaseInstance<ApplySofAcademyPage>.Instance.Validator.AssertIsInCandidatePeriod();
        }

        [TestMethod]
        public void Settings_DoesIsCourseUnenrollmentActiveFunctionsCorrectly()
        {
            const string SettingName = "IsCourseUnenrollmentActive";

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "false");
            BaseInstance<SeleniumIdePage>.Instance.Validator.AssertUnenrollmentNotActive();
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "true");
            BaseInstance<SeleniumIdePage>.Instance.Validator.AssertUnenrollmentActive();
        }

        [TestMethod]
        public void Settings_DoesFirstHomePageCourseInstanceFunctionsCorrectly()
        {
            const string SettingName = "FirstHomePageCourseInstance";
            const string CourseName = "Курс \"Kids Course\"";
            const int CourseId = 2;

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "{" + CourseName + "} = {" + CourseId + "}");
            BaseInstance<MainPage>.Instance.Validator.AssertCourseButtonPresent(CourseName, CourseId);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "{} = {}");
            BaseInstance<MainPage>.Instance.Validator.AssertCourseButtonNotPresent(CourseName, CourseId);
        }

        [TestMethod]
        public void Settings_DoesSecondHomePageCourseInstanceFunctionsCorrectly()
        {
            const string SettingName = "SecondHomePageCourseInstance";
            const string CourseName = "Test Course2";
            const int CourseId = 4;

            BaseInstance<LoginPage>.Instance.LoginUser(currentUser);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "{" + CourseName + "} = {" + CourseId + "}");
            BaseInstance<MainPage>.Instance.Validator.AssertCourseButtonPresent(CourseName, CourseId);
            BaseInstance<SettingsPage>.Instance.ModifySetting(SettingName, null, "{} = {}");
            BaseInstance<MainPage>.Instance.Validator.AssertCourseButtonNotPresent(CourseName, CourseId);
        }
    }
}
