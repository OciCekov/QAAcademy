namespace TestingFramework_HW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for CalculatorTests
    /// </summary>
    [TestClass]
    public class CalculatorSimpleTests : BaseTest
    {
        private string desiredButtons;
        private string expected;
        private string actual;

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;

        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string) TestContext.Properties["TestName"]);

            #endregion

            Manager.Settings.ExecutionDelay = 2;
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            Manager.Settings.Web.RecycleBrowser = true;
            ActiveBrowser.NavigateTo(
                @"http://www.webestools.com/ftp/ybouane/scripts_tutorials/javascript/calculator/calculator.html");
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            // It's ugly, and probably not the correct way to do this, but it's good to see what actually is shown in thecalculator;
            Thread.Sleep(1000);

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
        public void WritesCorrectValues()
        {
            // Yes I admit it's stupid to enter "," and then wait for ".", but that's how the calc is made 
            desiredButtons = "123456780,";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "1234567890.";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication()
        {
            desiredButtons = "2x2";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "4";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3564x2569";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "9155916";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3,5x4,8";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "16.8";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Aggregation()
        {
            desiredButtons = "2+2";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "4";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3564+2569";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "6133";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3,5+4,8";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "8.3";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtraction()
        {
            desiredButtons = "4-2";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "2";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3564-2569";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "995";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3,5-4,8";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "-1.3";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division()
        {
            desiredButtons = "8÷2";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "4";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual); // Yes it fails... on pourpose

            desiredButtons = "3564÷2569";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "1.3873102374464772284935772674192";       // I didn't know where it cuts, so this is from windows calc.
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombinedFunctions()
        {
            desiredButtons = "3564-2569+48x6-29x356967";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "2223547443";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "3564x2569+45-3333333333";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "-3324177372";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BigNumbersAggregation()
        {
            desiredButtons = "9999999999+1";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "10000000000";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "9999999999+9999999999+2";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "20000000000";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
          
            desiredButtons = "999999999925655896+9999999999321543312";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "10999999999247199208"; // You can actually make calculator with javascript... awh that's cute :D 
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BigNumbersMultiplication()
        {
            desiredButtons = "9999999999x9999999999";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "99999999980000000001"; 
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BigNumbersSubtraction()
        {
            desiredButtons = "9999999999-999999999999";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "-990000000000";
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);

            desiredButtons = "99999999992565-9999999999321543312";
            this.Press(this.CalculatorButtons(desiredButtons));
            expected = "-9999899999321550747"; 
            actual = Find.ById<HtmlInputText>("calc_result").Text;
            Assert.AreEqual(expected, actual);
        }
        private void Press(IEnumerable<HtmlInputButton> buttons)
        {
            foreach (HtmlInputButton button in buttons)
            {
                button.Click();
            }
            this.Find.ByAttributes<HtmlInputButton>("value==").Click();
        }

        private IEnumerable<HtmlInputButton> CalculatorButtons(string values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "cannot be empty");
            }

            return values.Select(t => this.Find.ByAttributes<HtmlInputButton>("value=" + t)).ToList();
        }
    }
}