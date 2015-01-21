namespace TestingFramework_HW
{
    using System;
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchTest : BaseTest
    {
        private HtmlInputText searchField;
        private HtmlInputSubmit submitButton;

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            SetTestMethod(this, (string) TestContext.Properties["TestName"]);

            #endregion
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        [TestMethod]
        public void SearchInputTest()
        {
            Manager.Settings.ExecutionDelay = 1;
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(@"http://telerikacademy.com");

            Assert.IsTrue(this.NothingFound("F the what")); // FTW? :D
            Assert.IsTrue(this.ReturnsCoursesAndTracks("WPF"));
            Assert.IsTrue(this.ReturnsCoursesTracksAndUser("Quality"));
        }

        private bool NothingFound(string searchterm)
        {
            this.Search(searchterm);
            try
            {
                ActiveBrowser.WaitForElement(new HtmlFindExpression("textcontent=Вашето търсене не върна резултат"),
                    1000, false);
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
        }

        private bool ReturnsCoursesAndTracks(string searchterm)
        {
            this.Search(searchterm);
            try
            {
                this.CheckField("Курсове");
                this.CheckField("Тракове");
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
        }

        private bool ReturnsCoursesTracksAndUser(string searchterm)
        {
            this.Search(searchterm);
            try
            {
                this.CheckField("Потребители");
                this.CheckField("Курсове");
                this.CheckField("Тракове");
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
        }

        private void Search(string condition)
        {
            searchField = Find.ById<HtmlInputText>("SearchTerm");
            submitButton = Find.ById<HtmlInputSubmit>("SearchButton");
            this.searchField.Text = condition;
            this.submitButton.Click();
        }

        private void CheckField(string requiredField)
        {
            ActiveBrowser.WaitForElement(new HtmlFindExpression("textcontent=~Вашето търсене"), 30000, false);

            Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                .Where(div => div.InnerText.Contains(requiredField))
                .FirstOrDefault()
                .Find.ByAttributes<HtmlUnorderedList>("class=SeachMetroList");
        }
    }
}