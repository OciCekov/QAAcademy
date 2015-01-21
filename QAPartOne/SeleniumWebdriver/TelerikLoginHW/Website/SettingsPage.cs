namespace TelerikLoginHW.Website
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using OpenQA.Selenium.Support.UI;

    internal class SettingsPage
    {
        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbNick_tbSanitized"
            )]
        public IWebElement NickName { get; set; }

        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbFirstName_tbSanitized"
            )]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbLastName_tbSanitized"
            )]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbCompanyName_tbSanitized"
            )]
        public IWebElement CompanyName { get; set; }

        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_ucCountrySelector_rcbCountry_Input"
            )]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Id,
            Using = "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_lbUpdate"
            )]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.Id,
            Using =
                "ctl00_ctl00_GeneralBox_Content_usercontrols_public_unitedaccount_client_editprofile_ascx1_scetbCompanyName_rfvSanitizedControl"
            )]
        public IWebElement EmptyCompanyWarningMessage { get; set; }

        public void ChangeSettings(IWebDriver driver, string userNickname, string userFirstName,
            string userLastName, string country = "Bahamas", string userCompanyName = "")
        {
            PageFactory.InitElements(driver, this);
            this.NickName.Clear();
            this.NickName.SendKeys("Pesho,");
            this.FirstName.Clear();
            this.FirstName.SendKeys("The");
            this.LastName.Clear();
            this.LastName.SendKeys("Ninja");
            this.CompanyName.Clear();
            this.Country.Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(e => this.Country.Enabled);
            wait.Until(e => this.Country.Displayed);

            //  Yes this was the only way to make it work, if you have any ideas please do share. 
            this.Country.SendKeys(country[0].ToString());
            var selectedCountry = driver.FindElement(By.XPath("//li[text()='" + country + "']"));

            selectedCountry.Click();
        }

        public void ChangeCompanyName(IWebDriver driver, string newCompanyName)
        {
            PageFactory.InitElements(driver, this);
            this.CompanyName.Clear();
            this.CompanyName.SendKeys(newCompanyName);
            this.CompanyName.SendKeys(Keys.Tab);
        }
    }
}