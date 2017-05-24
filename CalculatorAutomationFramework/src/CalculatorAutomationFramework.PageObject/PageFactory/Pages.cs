using CalculatorAutomationFramework.PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationFramework.PageObject.PageFactory
{
    public static class Pages
    {

        #region Pages
        public static CalculatorHomePage CalculatorHomePage => GetPage<CalculatorHomePage>();
        #endregion

        public static T GetPage<T>()where T : new()
        {
            var page = new T();
            return page;
        }
    }
}
