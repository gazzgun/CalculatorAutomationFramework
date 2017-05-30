using CalculatorAutomationFramework.Common;
using CalculatorAutomationFramework.Common.Helpers;
using CalculatorAutomationFramework.PageObject.PageFactory;
using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace CalculatorAutomationFramework.PageObject.Pages
{
    public class CalculatorHomePage : BasePage
    {


        private Button equalsButton = WindowDriver.Instance.Get<Button>("Equals");
        private Label  resulTtextBox = WindowDriver.Instance.Get<Label>(SearchCriteria.ByAutomationId("150"));

        public string ReturnCalculatedResult()=> resulTtextBox.Text;

        public void Calculate(string button1,string button2,string function)
        {
            var b1 = WindowDriver.Instance.Get<Button>(button1);
            var b2 = WindowDriver.Instance.Get<Button>(button2);
            var b3 = WindowDriver.Instance.Get<Button>(function);
            b1.Click();
            b3.Click();
            b2.Click();
           equalsButton.Click();
        }

        

        
    }
}
