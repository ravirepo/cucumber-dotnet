using System;
using TechTalk.SpecFlow;

namespace ConsoleApp1
{
    [Binding]
    public class ValidationOfDiscountCalculationSteps
    {
        DiscountCalcEngine.DiscountCalculator discountCalculator;
        int actual = 0;
        bool isSeniorCitizen;

        [Given(@"I am a customer who is looking for a discount")]
        public void GivenIAmACustomerWhoIsLookingForADiscount()
        {
            discountCalculator = new DiscountCalcEngine.DiscountCalculator();
        }
        
        [Given(@"My address is in ""(.*)""")]
        public void GivenMyAddressIsIn(string state)
        {
            discountCalculator.State = state;
        }

        [Given(@"My Profession is ""(.*)""")]
        public void GivenMyProfessionIs(string profession)
        {
            discountCalculator.Profession = profession;
        }

        [When(@"I view my discount")]
        public void WhenIViewMyDiscount()
        {
            actual = discountCalculator.calculateDiscount();
        }
        
        [Then(@"I expect a ""(.*)"" percent discount")]
        public void ThenIExpectAPercentDiscount(int expected)
        {
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
