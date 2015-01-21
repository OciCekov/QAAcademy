namespace TelerikLoginHW
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.PageObjects;
    using TelerikLoginHW.Website;

    [TestClass]
    public class TestsCases : BaseFunctionality
    {
        [TestInitialize]
        public void SetUp()
        {
            this.Driver = Driver;
            this.Url = @"http://Telerik.com";
            this.Timeout = 20;
        }

        [TestMethod]
        public void ChangeSettingsWithWrongCompanyName()
        {
            this.Driver = new ChromeDriver(@"E:\");
            var settings = new SettingsPage();
            this.GetToSettings(this.Driver);

            settings.ChangeSettings(this.Driver, "Pesho", "The", "Ninja", "Ecuador");
            this.WaitForElement(settings.EmptyCompanyWarningMessage, this.Driver);
            var expected = settings.EmptyCompanyWarningMessage.Displayed;

            Assert.IsTrue(expected);
            this.Driver.Quit();
        }

        [TestMethod]
        public void ChangeSettingsWithCorrectCompanyName()
        {
            this.Driver = new ChromeDriver(@"E:\");
            var settings = new SettingsPage();
            var randomLength = new Random();
            var randomCompanyName = this.RandomString(randomLength.Next(3, 15));
            this.GetToSettings(this.Driver);
            settings.ChangeCompanyName(this.Driver, randomCompanyName);
            var expected = settings.EmptyCompanyWarningMessage.Displayed;

            Assert.IsFalse(expected);
            this.Driver.Quit();
        }

        public void GetToSettings(IWebDriver driver)
        {
            var mainPage = new MainPage();
            var navigation = new UserNavigationBox();

            PageFactory.InitElements(this.Driver, navigation);
            mainPage.LogUser(this.Driver);

            navigation.OpenNavigation.Click();
            this.WaitForElement(navigation.EditOptionsLink, driver);
            navigation.EditOptionsLink.Click();
        }
    }
}