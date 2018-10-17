namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
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
        /// SimpleWPFTest - Use 'SimpleWPFTestParams' to pass parameters into this method.
        /// </summary>

        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }
        public void ModifiedSimpleWPFTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Desktop\101632129\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleWPFTestParams.UIMainWindowWindowExePath, this.SimpleWPFTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(72, 7));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleWPFTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(32, 5));
        }

        public virtual SimpleWPFTestParams SimpleWPFTestParams
        {
            get
            {
                if ((this.mSimpleWPFTestParams == null))
                {
                    this.mSimpleWPFTestParams = new SimpleWPFTestParams();
                }
                return this.mSimpleWPFTestParams;
            }
        }

        private SimpleWPFTestParams mSimpleWPFTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleWPFTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleWPFTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\101632129\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\Desktop\\101632129\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\SimpleWPFA" +
            "pp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\Desktop\101632129\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Desktop\\101632129\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\SimpleWPFApp." +
            "exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
