namespace TelerikLoginHW.Website
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    internal class MainPage
    {
        [FindsBy(How = How.Id, Using = "hlYourAccount")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "LoginButton")]
        public IWebElement LoginButton { get; set; }

        public void LogUser(IWebDriver driver, string email = "a4130403@trbvm.com", string currentPassword = "12345")
        {
            PageFactory.InitElements(driver, this);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(@"http://www.telerik.com/");
            driver.Navigate().Refresh();

            this.LoginLink.Click();
            this.EmailField.Clear();
            this.EmailField.SendKeys(email);
            this.Password.Clear();
            this.Password.SendKeys(currentPassword);
            this.LoginButton.Click();
        }
    }
}