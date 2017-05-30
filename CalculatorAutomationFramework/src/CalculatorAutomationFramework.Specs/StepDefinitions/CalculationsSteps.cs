using CalculatorAutomationFramework.Common.Helpers;
using CalculatorAutomationFramework.PageObject.PageFactory;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WindowsInput.Native;

namespace CalculatorAutomationFramework.Specs.StepDefinitions
{
    [Binding]
    public class CalculationsSteps
    {
        [Given(@"the application is open")]
        public void GivenTheApplicationIsOpen()
        {
            Assert.AreEqual("Calculator", WindowDriver.Instance.Title);
        }
        
        [When(@"I enter the following")]
        public void WhenIEnterTheFollowing(Table table)
        {
            foreach(var row in table.Rows)
                Pages.CalculatorHomePage.Calculate(row[0],row[1],row[2]);
        }
        
        [Then(@"I should see this ""(.*)""")]
        public void ThenIShouldSeeThis(string result)
        {
            Assert.True(Pages.CalculatorHomePage.ReturnCalculatedResult().Contains(result));
        }

        [When(@"I open the file browser")]
        public void WhenIOpenTheFileBrowser()
        {
            Pages.SientificCalculator.OpenFileWindow();
        }

        [Then(@"the file browser should be open")]
        public void ThenTheFileBrowserShouldBeOpen()
        {
            Assert.True(Pages.SientificCalculator.VerifyFileBrowserWindow());
        }


    }
}
