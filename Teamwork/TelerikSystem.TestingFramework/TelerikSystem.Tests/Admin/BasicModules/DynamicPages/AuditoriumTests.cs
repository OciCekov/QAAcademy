namespace TelerikSystem.Tests.Admin.BasicModules.Auditoriums
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using System.Linq;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;
    using Assert = NUnit.Framework.Assert;


    public class AuditoriumTests : BaseTest
    {
        private User testUser;

        [SetUp]
        public override void TestInit()
        {
            this.testUser = new User
            {
                Username = "kalimar",
                Password = "space password"
            };
        }

        [Owner("Kalin Marinov")]
        [Priority(3)]
        [TestCase("test", "test", "30", "testing stuff")]
        [TestCase("zala", "address", "", " ")]
        [TestCase("на български", "на адрес", "пак български", "пак български")]
        public void Auditorium_CanCreateValidAuditorium(string name, string address, string capacity, string equipment)
        {
            Pages<LoginPage>.Instance.LoginUser(testUser);

            var sut = Pages<AuditoriumPage>.Instance;

            sut.Navigate();
            sut.AddAuditorium(name, address, capacity, equipment);
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(allAuditoriums.Any(x => x.Name == name));
        }

        [Test]
        public void Auditorium_CanDeleteAuditorium()
        {
            var sut = Pages<AuditoriumPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);

            sut.Navigate();
            sut.DeleteAuditorium(9);
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(!allAuditoriums.Any(x => x.Name == "test"));
        }
    }
}
