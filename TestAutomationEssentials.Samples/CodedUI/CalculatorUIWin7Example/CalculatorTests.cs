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
            LaunchTheWindowsApp();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }


        [TestMethod]
        public void Calculator_Add_One_Plus_Two_Should_Eqaul_Three()
        {

            Mouse.Click(calcApp.Find<WinButton>(By.Name("1")));
            Mouse.Click(calcApp.Find<WinButton>(By.Name("Add")));
            Mouse.Click(calcApp.Find<WinButton>(By.Name("2")));
            Mouse.Click(calcApp.Find<WinButton>(By.Name("Equals")));

            // Verify that the 'DisplayText' property of '0' label equals '3'
            Assert.AreEqual(calcApp.Find<WinText>(By.Name("Result")).DisplayText, "3", "Result is incorrect");
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

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
    }
}
