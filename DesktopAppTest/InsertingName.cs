/*
 * Created by Ranorex
 * User: MRashid
 * Date: 8/5/2020
 * Time: 12:58 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace DesktopAppTest
{
    /// <summary>
    /// Description of InsertingName.
    /// </summary>
    [TestModule("B1E19704-D332-4BA0-BF5B-4BE190EF0A7C", ModuleType.UserCode, 1)]
    public class InsertingName : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertingName()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
        }
    }
}
