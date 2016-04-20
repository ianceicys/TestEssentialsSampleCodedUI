namespace CalculatorUIWin7Example
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// Click1Button
        /// </summary>
        public void Click1Button()
        {
            #region Variable Declarations
            WinButton uIItem1Button = this.UICalculatorWindow.UIItemWindow.UIItem1Button;
            #endregion

            // Click '1' button
            Mouse.Click(uIItem1Button, new Point(26, 20));
        }

        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinText uIItemResultText = this.UICalculatorWindow.UIItemWindow.UIItemResultText;
            #endregion

            // Verify that the 'DisplayText' property of '0' label equals '3'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIItemResultTextDisplayText, uIItemResultText.DisplayText, "Result is incorrect");
        }

        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }

        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
    }
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AssertMethod1ExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of '0' label equals '3'
        /// </summary>
        public string UIItemResultTextDisplayText = "3";
        #endregion
    }
}
