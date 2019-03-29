using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp1
{
    [Binding]
    public class VerifyDiscountWebsiteSteps
    {
        IWebDriver driver;

        [Before ("web")]
        void setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability(CapabilityType.Version, "latest", true);
            options.AddAdditionalCapability(CapabilityType.Platform, "WIN10", true);

            driver = new ChromeDriver(options);
        }

        [After("web")]
        void cleanUp()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        [Given(@"I am a customer who is looking for a discount on the website")]
        public void GivenIAmACustomerWhoIsLookingForADiscountOnTheWebsite()
        {
            driver.Navigate().GoToUrl("http://localhost:51806/");
        }

        [Given(@"My address is in ""(.*)"" on the website")]
        public void GivenMyAddressIsInOnTheWebsite(string state)
        {
            driver.FindElement(By.Id("MainContent_ddlState")).SendKeys(state);
        }

        [When(@"I view my discount on the website")]
        public void WhenIViewMyDiscountOnTheWebsite()
        {
            driver.FindElement(By.Id("MainContent_btnSubmit")).Click();
        }

        [Then(@"I expect a ""(.*)"" percent discount on the website")]
        public void ThenIExpectAPercentDiscountOnTheWebsite(int expected)
        {
            NUnit.Framework.Assert.AreEqual(driver.FindElement(By.Id("MainContent_lblDiscount")).Text, expected.ToString());
        }
    }
}
