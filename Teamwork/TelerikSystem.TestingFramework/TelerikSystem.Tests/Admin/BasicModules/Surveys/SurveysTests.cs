namespace TelerikSystem.Tests.Admin.BasicModules.Surveys
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Globalization;
    using TelerikSystem.Core.Admin.BasicModules.Pages.SurveysPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class SurveysTests : BaseTest
    {
        private User currentUser;
        private string startDate;
        private string endDate;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
            startDate = DateTime.Now.AddDays(2)
                .ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            endDate = DateTime.Now.AddDays(2)
                .AddMinutes(2)
                .ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
        }

        [TestMethod]
        public void Surveys_CanAddNewSurvey()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<SurveysPage>.Instance.AddNewSurvey("NAMEMEME", startDate, endDate);
            Pages<SurveysPage>.Instance.Validator.AssertSurveyExists("LEL");
        }
    }
}
