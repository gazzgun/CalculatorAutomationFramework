using CalculatorAutomationFramework.Common.Helpers;
using CalculatorAutomationFramework.PageObject.PageFactory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorAutomationFramework.Specs.StepDefinitions
{
    [Binding]
    public sealed class TestSteps
    {
        [Given(@"calculator application is open")]
        public void GivenCalculatorApplicationIsOpen()
        {
           //Console.WriteLine();
           //Console.WriteLine("I AM HERE");
           //Console.WriteLine();
           //Assert.AreEqual("Calculator",WindowDriver.Instance.Title);
        }

        [When(@"I enter two ""(.*)"" ""(.*)"" number and do a matamatical fucntion to them ""(.*)""")]
        public void WhenIEnterTwoNumberAndDoAMatamaticalFucntionToThem(string firstNumber, string secondNumber, string function)
        {
            Pages.CalculatorHomePage.Calculate(firstNumber,secondNumber,function);
        }

        [Then(@"the result should be this ""(.*)""")]
        public void ThenTheResultShouldBeThis(string result)
        {
            Assert.True(Pages.CalculatorHomePage.ReturnCalculatedResult().Contains(result));
        }



    }
}
