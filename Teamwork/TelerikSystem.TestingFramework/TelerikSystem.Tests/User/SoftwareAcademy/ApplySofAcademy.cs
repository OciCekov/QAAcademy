namespace TelerikSystem.Tests.User.SoftwareAcademy
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;

    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;
 //   using NUnit.Framework;

    [TestClass]
    public class ApplySofAcademy : BaseTest
    {
        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
        }

        //[TestMethod]
        //[DataSource("Users")]
        //[DeploymentItem(@"C:\MyStaff\RedcurrantTFS\TelerikSystemPerformanceTesting\PerformanceTesting\DataUsers\VioletaUsers3.csv")]
        //public void VerifyApplySofAcademy()
        //{
        //     string username = TestContext.DataRow["username"].ToString();

        //    Pages<ApplySofAcademyPage>.Instance.Validator.VerifyUserHasApplied(username, "123456");
        //}
 
    }
}
