﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.457")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinButton uIButton1Button = this.UIForm1Window.UIButton1Window.UIButton1Button;
            #endregion

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 5));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));
        }
        
        /// <summary>
        /// RecordedMethod2
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WinButton uIButton1Button = this.UIForm1Window.UIButton1Window.UIButton1Button;
            #endregion

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 5));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(31, 11));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(41, 14));

            // Click 'button1' button
            Mouse.Click(uIButton1Button, new Point(9, 4));
        }
        
        #region Properties
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        #endregion
        
        #region Fields
        private UIForm1Window mUIForm1Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.457")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UIButton1Window UIButton1Window
        {
            get
            {
                if ((this.mUIButton1Window == null))
                {
                    this.mUIButton1Window = new UIButton1Window(this);
                }
                return this.mUIButton1Window;
            }
        }
        #endregion
        
        #region Fields
        private UIButton1Window mUIButton1Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.457")]
    public class UIButton1Window : WinWindow
    {
        
        public UIButton1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UIButton1Button
        {
            get
            {
                if ((this.mUIButton1Button == null))
                {
                    this.mUIButton1Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIButton1Button.SearchProperties[WinButton.PropertyNames.Name] = "button1";
                    this.mUIButton1Button.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIButton1Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIButton1Button;
        #endregion
    }
}
