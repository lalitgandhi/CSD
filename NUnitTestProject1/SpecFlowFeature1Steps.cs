using NUnit.Framework;
using RPNCalc;
using System;
using TechTalk.SpecFlow;

namespace NUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        string expr;

        [Given(@"User enter ""(.*)""")]
        public void GivenUserEnter(string p0)
        {
            expr = p0;
            
            // ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            RPNCalculator calc = new RPNCalculator();
            int result = calc.MyCalc(expr);
            Assert.AreEqual(8, result);
            //ScenarioContext.Current.Pending();
        }
    }
}
