using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsTestProject.Pom;
using System;
using TechTalk.SpecFlow;

namespace SwagLabsTestProject.StepDefinitions
{
    [Binding]
    public class CheckoutProcessValidationStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly CheckoutPage _checkoutPage;

        public CheckoutProcessValidationStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _checkoutPage = new CheckoutPage(driver);
        }

        [Given(@"the user click the checkout button")]
        public void GivenTheUserClickTheCheckoutButton()
        {
            _checkoutPage.ClickCheckout();
        }

        [When(@"they enter ""([^""]*)"" in the First Name field")]
        public void WhenTheyEnterInTheFirstNameField(string p0)
        {
            _checkoutPage.EnterFirstName(p0);
        }

        [When(@"they enter ""([^""]*)"" in the Last Name field")]
        public void WhenTheyEnterInTheLastNameField(string p0)
        {
            _checkoutPage.EnterLastName(p0);
        }

        [When(@"they enter ""([^""]*)"" in the Zip Code field")]
        public void WhenTheyEnterInTheZipCodeField(string p0)
        {
            _checkoutPage.EnterZipCode(p0);
        }

        [When(@"they click the Continue button")]
        public void WhenTheyClickTheContinueButton()
        {
            _checkoutPage.ClickContinue();
        }

        [Then(@"they should see an error message ""([^""]*)""")]
        public void ThenTheyShouldSeeAnErrorMessage(string p0)
        {
            Assert.That(_checkoutPage.GetErrorMessage(), Is.EqualTo(p0));
        }

        [Then(@"they should see Price Total ""([^""]*)""")]
        public void ThenTheyShouldSeePriceTotal(string p0)
        {
            Assert.That(_checkoutPage.GetPriceTotal(), Is.EqualTo(p0));
        }

        [When(@"they click the Finish button")]
        public void WhenTheyClickTheFinishButton()
        {
            _checkoutPage.ClickFinish();
        }

        [Then(@"they should see the messages ""([^""]*)"" and ""([^""]*)""")]
        public void ThenTheyShouldSeeTheMessagesAnd(string p0, string p1)
        {
           Assert.That(_checkoutPage.GetConfirmationMessage(), Is.EqualTo(p0));
           Assert.That(_checkoutPage.GetDispatchMessage(), Is.EqualTo(p1));
        }

        [Then(@"they should see the ""([^""]*)"" button")]
        public void ThenTheyShouldSeeTheButton(string p0)
        {
            Assert.That(_checkoutPage.IsBackHomeButtonDisplayed);
        }
    }
}
