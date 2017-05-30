using CalculatorAutomationFramework.Common;
using CalculatorAutomationFramework.Common.Helpers;
using CalculatorAutomationFramework.PageObject.PageFactory;
using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects.ScreenAttributes;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;

namespace CalculatorAutomationFramework.PageObject
{
    public class SientificCalculator : BasePage
    {
        protected override ISikuliSession Session => SikuliSetup.GetSession();

        private Menu view => WindowDriver.Instance.Get<Menu>("View");
        private Menu standard => WindowDriver.Instance.Get<Menu>("Standard");
        private Menu scientific => WindowDriver.Instance.Get<Menu>("Scientific");

        private IPattern fileWindow = Patterns.FromFile(@"C:\Users\Gary Gunning\Source\Repos\CalculatorAutomationFramework\CalculatorAutomationFramework\src\CalculatorAutomationFramework.PageObject\SikuliImages\FileWindow.PNG");
        private IPattern fileBrowserWindow= Patterns.FromFile(@"C:\Users\Gary Gunning\Source\Repos\CalculatorAutomationFramework\CalculatorAutomationFramework\src\CalculatorAutomationFramework.PageObject\SikuliImages\FileBrowserWindow.PNG");
        private IPattern closeWindow = Patterns.FromFile(@"C:\Users\Gary Gunning\Source\Repos\CalculatorAutomationFramework\CalculatorAutomationFramework\src\CalculatorAutomationFramework.PageObject\SikuliImages\CloseWindow.PNG");

        public void SwitchTo(string calcType)
        {
            view.Click();
            scientific.Click();
        }
        public void SwitchToStandard()
        {
            view.Click();
            standard.Click();
        }

        public void OpenFileWindow()
        {
            Session.Click(fileWindow);
        }
        public bool VerifyFileBrowserWindow()
        {
            return Session.Wait(fileBrowserWindow,10);
        }
        public void CloseWindow()
        {
            Session.Click(closeWindow);
        }
    }
}
