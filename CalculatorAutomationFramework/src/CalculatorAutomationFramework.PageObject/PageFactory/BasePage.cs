using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationFramework.PageObject.PageFactory
{
    public abstract class BasePage
    {
        protected virtual ISikuliSession Session { get; }
    }
}
