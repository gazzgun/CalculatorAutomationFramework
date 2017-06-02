using SikuliSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationFramework.PageObject.PageFactory
{
    public abstract class BasePage
    {
        protected virtual ISikuliSession Session { get; set; }
        protected virtual string SikuliPath { get; }
        
    }
}
