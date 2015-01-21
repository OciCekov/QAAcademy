namespace TelerikLoginHW
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class BaseFunctionality // aka the engine
    {
        private const int DefaultTimeout = 20;
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static readonly Random RandomLetter = new Random();

        public void InitializeTestData(IWebDriver driver, string baseUrl, int timeout)
        {
            this.Driver = driver;
            this.Url = baseUrl;
            this.Timeout = timeout;
        }

        public IWebDriver Driver { get; set; }

        public string Url { get; set; }

        public int Timeout { get; set; }

        public IWebElement WaitForElement(IWebElement element, IWebDriver driver, int timeout = DefaultTimeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(e => element.Displayed);
            wait.Until(e => element.Enabled);
            return element;
        }

        public string RandomString(int length)
        {
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                int index = RandomLetter.Next(0, Letters.Length - 1);
                result[i] = Letters[index];
            }

            return new string(result);
        }
    }
}