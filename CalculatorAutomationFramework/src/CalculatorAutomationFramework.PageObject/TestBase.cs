using CalculatorAutomationFramework.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationFramework.PageObject
{
    public static class TestBase
    {
        public static void TestSetup(string title, string path)
        {
            WindowDriver.ApplicationPath = ApplicationSettings.GetApplicationPath(path);
            WindowDriver.ApplicationTitle = ApplicationSettings.GetApplicationTitle(title);

            if (WindowDriver.Window == null)
                WindowDriver.GrabWindow();
        }

        public static void TearDown()
        {
            WindowDriver.CloseApplication();
            WindowDriver.Window = null;
        }

      
    }
}
