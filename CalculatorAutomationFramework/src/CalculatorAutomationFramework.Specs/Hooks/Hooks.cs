using CalculatorAutomationFramework.Common;
using CalculatorAutomationFramework.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorAutomationFramework.Specs.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeFeature()
        {
            SikuliSetup.CreateSession();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            TestBase.TestSetup("applicationTitle", "applicationPath");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestBase.TearDown();
        }
    }
}
