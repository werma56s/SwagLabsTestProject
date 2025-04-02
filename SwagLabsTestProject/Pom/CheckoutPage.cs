using OpenQA.Selenium;
using SwagLabsTestProject.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Pom
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;
        private CheckoutForm _checkoutForm;

        private By firstNameField = By.Id("first-name");
        private By lastNameField = By.Id("last-name");
        private By zipCodeField = By.Id("postal-code");
        private By continueButton = By.Id("continue");
        private By checkoutButton = By.Id("checkout");
        private By finishButton = By.Id("finish");
        private By errorMessage = By.CssSelector("h3[data-test='error']");
        private By priceTotal = By.ClassName("summary_total_label");
        private By confirmationMessage = By.ClassName("complete-header");
        private By dispatchMessage = By.ClassName("complete-text");
        private By backHomeButton = By.Id("back-to-products");

        public CheckoutPage(IWebDriver driver)
        {
            this._driver = driver;
            this._checkoutForm = new RandomData().GetRandomCheckoutForm();
        }

        public void EnterFirstName(string firstName)
        {
            if(firstName == "random.firstname")
            {
                firstName = _checkoutForm.FirstName;
            } else if(firstName == "empty")
            {
                firstName = "";
            }
            _driver.FindElement(firstNameField).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            if (lastName == "random.lastname")
            {
                lastName = _checkoutForm.LastName;
            }
            else if (lastName == "empty")
            {
                lastName = "";
            }
            _driver.FindElement(lastNameField).SendKeys(lastName);
        }

        public void EnterZipCode(string zipCode)
        {
            if (zipCode == "random.zipcode")
            {
                zipCode = _checkoutForm.PostalCode;
            }
            else if (zipCode == "empty")
            {
                zipCode = "";
            }
            _driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        public void ClickContinue() => _driver.FindElement(continueButton).Click();
        
        public void ClickCheckout() => _driver.FindElement(checkoutButton).Click();

        public void ClickFinish() => _driver.FindElement(finishButton).Click();

        public string GetErrorMessage() => _driver.FindElement(errorMessage).Text;

        public string GetPriceTotal() => _driver.FindElement(priceTotal).Text;

        public string GetConfirmationMessage() => _driver.FindElement(confirmationMessage).Text;

        public string GetDispatchMessage() => _driver.FindElement(dispatchMessage).Text;

        public bool IsBackHomeButtonDisplayed() => _driver.FindElement(backHomeButton).Displayed;
    }
}
