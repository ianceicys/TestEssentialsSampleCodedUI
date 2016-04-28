using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using TestAutomationEssentials.CodedUI;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System.IO;

namespace CalculatorUIWin7Example
{
    /// <summary>
    /// Summary description for Calculator_Add_One_Plus_Two_Should_Eqaul_Three
    /// </summary>
    [CodedUITest]
    public class CalculatorTests
    {
        public CalculatorTests()
        {

        }

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void TestInitialize()
        {
            //Configure the playback engine to increase test reliability
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            Playback.PlaybackSettings.MaximumRetryCount = 10;
            Playback.PlaybackSettings.ShouldSearchFailFast = false;
            Playback.PlaybackSettings.DelayBetweenActions = 200;
            Playback.PlaybackSettings.SearchTimeout = 3000;
            LaunchTheWindowsApp();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }


        [TestMethod]
        public void Calculator_One_Add_Two_Equals_Three_Should_EvaluateTrue()
        {
            //ARRANGE
            string input1   =         "1";
            string command1 =         "Add";
            string input2 =           "2";
            string command2 =         "Equals";
            string expectedresult =   "3";

            //ACT
            calcApp.Find<WinButton>(By.Name(input1)).Click();
            calcApp.Find<WinButton>(By.Name(command1)).Click();
            calcApp.Find<WinButton>(By.Name(input2)).Click();
            calcApp.Find<WinButton>(By.Name(command2)).Click();
            Mouse.Hover(calcApp.Find<WinText>(By.Name("Result")));

            // ASSERT 

            // Use Custom Logger Method to Log Addition Details
            CustomTestResultLogger(input1, input2, command1, command2, expectedresult);

            //Assert Statement at the end of the test
            Assert.AreEqual(
            expectedresult,
            calcApp.Find<WinText>(By.Name("Result")).DisplayText,
            "Application returned the incorrect value");
        }

        [TestMethod]
        public void Calculator_Two_Add_Two_Equals_Four_Should_EvaluateTrue()
        {
            //ARRANGE
            string input1 =         "2";
            string command1 =       "Add";
            string input2 =         "2";
            string command2 =       "Equals";
            string expectedresult = "4";

            //ACT
            calcApp.Find<WinButton>(By.Name(input1)).Click();
            calcApp.Find<WinButton>(By.Name(command1)).Click();
            calcApp.Find<WinButton>(By.Name(input2)).Click();
            calcApp.Find<WinButton>(By.Name(command2)).Click();
            Mouse.Hover(calcApp.Find<WinText>(By.Name("Result")));

            // ASSERT 

            // Use Custom Logger Method to Log Addition Details
            CustomTestResultLogger(input1, input2, command1, command2, expectedresult);

            //Assert Statement at the end of the test
            Assert.AreEqual(
            expectedresult,
            calcApp.Find<WinText>(By.Name("Result")).DisplayText,
            "Application returned the incorrect value");
        }

        [TestMethod]
        public void Calculator_Two_Multiply_Two_Equals_Four_Should_EvaluateTrue()
        {
            //ARRANGE
            string input1 =         "2";
            string command1 =       "Multiply";
            string input2 =         "2";
            string command2 =       "Equals";
            string expectedresult = "4";

            //ACT
            calcApp.Find<WinButton>(By.Name(input1)).Click();
            calcApp.Find<WinButton>(By.Name(command1)).Click();
            calcApp.Find<WinButton>(By.Name(input2)).Click();
            calcApp.Find<WinButton>(By.Name(command2)).Click();
            Mouse.Hover(calcApp.Find<WinText>(By.Name("Result")));

            // ASSERT 

            // Use Custom Logger Method to Log Addition Details
            CustomTestResultLogger(input1, input2, command1, command2, expectedresult);

            //Assert Statement at the end of the test
            Assert.AreEqual(
            expectedresult,
            calcApp.Find<WinText>(By.Name("Result")).DisplayText,
            "Application returned the incorrect value");
        }

        [TestMethod]
        public void Calculator_Two_Divide_Two_Equals_One_Should_EvaluateTrue()
        {
            //ARRANGE
            string input1 =         "2";
            string command1 =       "Divide";
            string input2 =         "2";
            string command2 =       "Equals";
            string expectedresult = "1";

            //ACT
            calcApp.Find<WinButton>(By.Name(input1)).Click();
            calcApp.Find<WinButton>(By.Name(command1)).Click();
            calcApp.Find<WinButton>(By.Name(input2)).Click();
            calcApp.Find<WinButton>(By.Name(command2)).Click();
            Mouse.Hover(calcApp.Find<WinText>(By.Name("Result")));

            // ASSERT 

            // Use Custom Logger Method to Log Addition Details
            CustomTestResultLogger(input1, input2, command1, command2, expectedresult);

            //Assert Statement at the end of the test
            Assert.AreEqual(
            expectedresult,
            calcApp.Find<WinText>(By.Name("Result")).DisplayText,
            "Application returned the incorrect value");
        }

        [TestMethod]
        public void Calculator_Nine_SquareRoot_Equals_Three_Should_EvaluateTrue()
        {
            //ARRANGE
            string input1 = "9";
            string command1 = "Square root";
            string command2 = "Equals";
            string expectedresult = "3";

            //ACT
            calcApp.Find<WinButton>(By.Name(input1)).Click();
            calcApp.Find<WinButton>(By.Name(command1)).Click();
            calcApp.Find<WinButton>(By.Name(command2)).Click();
            Mouse.Hover(calcApp.Find<WinText>(By.Name("Result")));

            // ASSERT 

            // Use Custom Logger Method to Log Addition Details
            CustomTestResultLogger(input1, input2, command1, command2, expectedresult);

            //Assert Statement at the end of the test
            Assert.AreEqual(
            expectedresult,
            calcApp.Find<WinText>(By.Name("Result")).DisplayText,
            "Application returned the incorrect value");
        }

        [TestMethod]
        public void Calculator_MenuItem_Help_About()
        {
            //ARRANGE
            WinWindow aboutWinWindow = new WinWindow();
            aboutWinWindow.SearchProperties.Add(WinWindow.PropertyNames.Name, "About", PropertyExpressionOperator.Contains);
            string expectebuilddversion = "Version 6.1 (Build 7601: Service Pack 1)";

            //ACT
            calcApp.Find<WinMenuItem>(By.Name("Help")).Click();
            calcApp.Find<WinMenuItem>(By.Name("About Calculator")).Click();
            string appbuildversion = aboutWinWindow.Find<WinText>(By.Name("Version 6.1 (Build 7601: Service Pack 1)")).DisplayText;
            Mouse.Hover(aboutWinWindow.Find<WinText>(By.Name("Version 6.1 (Build 7601: Service Pack 1)")));

            //ASSSERT
            Assert.AreEqual(
            expectebuilddversion,
            appbuildversion,
            "Incorrect Build Installed on Machine");


            aboutWinWindow.Find<WinButton>(By.Name("OK")).Click();
        }




        //[TestMethod]
        //public void Calculator_Mortgage_CalculateMonthlyPayment_200000_10000_30_5_Equals_1502_Should_EvaluateTrue()
        //{
        //    //ARRANGE

        //    //UI Control Names
        //    WinMenuItem menu_view = calcApp.Find<WinMenuItem>(By.Name("View"));
        //    WinMenuItem menu_worksheets = calcApp.Find<WinMenuItem>(By.Name("Worksheets"));
        //    menu_worksheets.SearchProperties[WinMenuItem.PropertyNames.Name] = "Worksheets";
        //    menu_worksheets.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
        //    WinMenuItem menu_mortgage = calcApp.Find<WinMenuItem>(By.Name("Mortgage"));
        //    menu_mortgage.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
        //    WinMenuItem menu_basic = calcApp.Find<WinMenuItem>(By.Name("Basic	Ctrl+F4"));
        //    menu_basic.SearchProperties[WinMenuItem.PropertyNames.Name] = "Basic	Ctrl+F4";
        //    menu_basic.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
        //    WinEdit purchaseprice = calcApp.Find<WinEdit>(By.Name("Purchase price"));
        //    WinEdit downpayment = calcApp.Find<WinEdit>(By.Name("Down payment"));
        //    WinEdit termyears = calcApp.Find<WinEdit>(By.Name("Term (years)"));
        //    WinEdit interestrate = calcApp.Find<WinEdit>(By.Name("Interest rate (%)"));
        //    WinButton calculate = calcApp.Find<WinButton>(By.Name("Calculate"));
        //    WinEdit monthlypayment = calcApp.Find<WinEdit>(By.Name("Monthly payment"));


        //    //Input values
        //    string purchasepricevalue =      "200000";
        //    string downpaymentvalue =        "10000";
        //    string termyearsvalue =          "30";
        //    string interestratevalue =       "5";
        //    string expectedresult =          "1019.961083723064";

        //    //ACT
        //    menu_view.Click();
        //    menu_basic.Click();
        //    //Mouse.Hover(menu_worksheets);
        //    //menu_worksheets.Click();
        //    //menu_mortgage.Click();
        //    //purchaseprice.Text = purchasepricevalue;
        //    //downpayment.Text = downpaymentvalue;
        //    //termyears.Text = termyearsvalue;
        //    //interestrate.Text = interestratevalue;
        //    //calculate.Click();
        //    //Mouse.Hover(monthlypayment);
        //    //menu_view.Click();


        //    // ASSERT 



        //    //Assert Statement at the end of the test
        //    Assert.AreEqual(
        //    expectedresult,
        //    calcApp.Find<WinText>(By.Name("Monthly Payment")).DisplayText,
        //    "Application returned the incorrect value");
        //}


        private void LaunchTheWindowsApp()
        {
            var pathToExe = Environment.GetEnvironmentVariable(
"TestAutomation-CodedUI-Sample-CalculatorWin7", EnvironmentVariableTarget.User);

            Assert.IsTrue(
                File.Exists(pathToExe),
                "Path to exe value does not point to a file that exists.  " +
                "The value is '{0}'.  Hint: Are you running on Windows 7" +
                " , this sample does not work on the Win8/Win10 Windows Store Calculator",
                pathToExe);

            calcApp = ApplicationUnderTest.Launch(pathToExe);
            //Reset calculator to known state
            calcApp.Find<WinMenuItem>(By.Name("View")).Click();
            calcApp.Find<WinMenuItem>(By.Name("Basic	Ctrl+F4")).Click();

        }

        private void CustomTestResultLogger(string input1,string input2,string command1, string command2, string expectedresult)
        {
            // Write to Standard Out (so that the log contains the
            // the result expected and the 'DisplayText' property
            // Why include Console.WriteLine to log if successful
            // Assert.AreEqual will only display logging message if
            // there is a failure

            Console.WriteLine(
            "Input1 = " + input1 +
            "\nInput2 = " + input2 +
            "\nOperator = " + command1 +
            "\nExpected result =  " + expectedresult +
            "\nResult DisplayText property = " + calcApp.Find<WinText>(By.Name("Result")).DisplayText +
            " in " + calcApp.Name + " app.");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:



        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
        private TestContext _testContext;


        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
        private string pathToExe;
        private ApplicationUnderTest calcApp;
        private string input1;
        private string input2;
        private string command1;
        private string command2;
        private string expectedresult;
    }
}
