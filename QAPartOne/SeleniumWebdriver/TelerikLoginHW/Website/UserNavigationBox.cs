namespace TelerikLoginHW.Website
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    internal class UserNavigationBox
    {
        [FindsBy(How = How.CssSelector,
            Using = "#ctl00_ctl00_siteNavigation30_functionalityControl30_liSignedIn > div:nth-child(1) > div")]
        public IWebElement OpenNavigation { get; set; }

        [FindsBy(How = How.Id, Using = @"ctl00_ctl00_siteNavigation30_functionalityControl30_hlProfile")]
        public IWebElement EditOptionsLink { get; set; }
    }
}