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

        [TestMethod]
        public void Calculator_Add_One_Plus_Two_Should_Eqaul_Three()
        {

            Mouse.Click(UIMap.UICalculatorWindow.Find<WinButton>(By.Name("1")));
            Mouse.Click(UIMap.UICalculatorWindow.Find<WinButton>(By.Name("Add")));
            Mouse.Click(UIMap.UICalculatorWindow.Find<WinButton>(By.Name("2")));
            Mouse.Click(UIMap.UICalculatorWindow.Find<WinButton>(By.Name("Equals")));

            // Verify that the 'DisplayText' property of '0' label equals '3'
            Assert.AreEqual(UIMap.UICalculatorWindow.Find<WinText>(By.Name("Result")).DisplayText, "3", "Result is incorrect");
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

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
    }
}
