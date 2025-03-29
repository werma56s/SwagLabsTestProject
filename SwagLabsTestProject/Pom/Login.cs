using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Pom
{
    public class Login
    {
        private readonly IWebDriver _driver;

        /*The approach using PageFactory and the[FindsBy] attribute is considered outdated.
        //The PageFactory class has been deprecated in Selenium, and it is recommended to use the By locators 
        directly with the IWebDriver instance.*/

        // Define the locators for the elements on the login page
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");
        private By errorMessageContainer = By.CssSelector("h3[data-test='error']");

        // Constructor to initialize the WebDriver
        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to enter the username
        public void EnterUsername(string username) => _driver.FindElement(usernameField).SendKeys(username);

        // Method to enter the password
        public void EnterPassword(string password) => _driver.FindElement(passwordField).SendKeys(password);

        // Method to click the login button
        public void ClickLoginButton() => _driver.FindElement(loginButton).Click();

        // Method to perform the login action
        public void LoginToApplication(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
        }

        //Displayed Fields
        public bool IsUsernameFieldDisplayed() => _driver.FindElement(usernameField).Displayed;

        public bool IsPasswordFieldDisplayed() => _driver.FindElement(passwordField).Displayed;

        public bool IsLoginButtonDisplayed() => _driver.FindElement(loginButton).Displayed;

        // Method to check if the error message matches the expected text
        public bool IsErrorMessageDisplayed(string expectedMessage)
        {
            var errorMessage = _driver.FindElement(errorMessageContainer).Text;
            return errorMessage == expectedMessage;
        }
    }
}
