using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsTestProject.Pom;
using SwagLabsTestProject.Support;

namespace SwagLabsTestProject.StepDefinitions
{
    [Binding]
    public class LoginToSwagLabsStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly Login _loginPage;
        private readonly Navigation _navigation;
        private readonly LoginDataProvider _loginDataProvider;
        private readonly ProductsPage _productsPage;

        public LoginToSwagLabsStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new Login(_driver);
            _navigation = new Navigation(_driver);
            _loginDataProvider = new LoginDataProvider();
            _productsPage = new ProductsPage(_driver);
        }

        [Given(@"I open the Swag Labs website")]
        public void GivenIOpenTheSwagLabsWebsite()
        {
            _navigation.GoToUrl(_loginDataProvider.GetUrl());
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_loginPage.IsUsernameFieldDisplayed(), "The username field is not displayed on the login page.");
                Assert.That(_loginPage.IsPasswordFieldDisplayed(), "The password field is not displayed on the login page.");
                Assert.That(_loginPage.IsLoginButtonDisplayed(), "The login button is not displayed on the login page.");
            });
        }

        [When(@"I enter credentials ""([^""]*)""")]
        public void WhenIEnterCredentials(string p0)
        {
            var (login, password) = _loginDataProvider.GetCredentials(p0);
            _loginPage.LoginToApplication(login, password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then(@"I should be taken to the products page")]
        public void ThenIShouldBeTakenToTheProductsPage()
        {
            Assert.That(_productsPage.AreInventoryItemsDisplayed(), "The inventory items are not displayed on the products page.");
        }

        [When(@"I enter username ""([^""]*)""")]
        public void WhenIEnterUsername(string username)
        {
            _loginPage.EnterUsername(username);
        }

        [When(@"I enter password ""([^""]*)""")]
        public void WhenIEnterPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }
        //
        [Then(@"I should see an error message ""([^""]*)""")]
        public void ThenIShouldSeeAnErrorMessage(string expectedMessage)
        {
            Assert.That(_loginPage.IsErrorMessageDisplayed(expectedMessage), $"The error message is not as expected. Expected: {expectedMessage}");
        }

        [Then(@"All product should have an incorrect image path ""([^""]*)""")]
        public void ThenAllProductShouldHaveAnIncorrectImagePath(string expectedSrc)
        {
            Assert.That(_productsPage.IsInventoryItemImageSrcCorrect(expectedSrc), "The inventory item image src is incorrect.");
        }

        [Then(@"The cart icon should be in the wrong place")]
        public void ThenTheCartIconShouldBeInTheWrongPlace()
        {
            Assert.That(_productsPage.IsCartIconInWrongPlace(), "The cart icon is not in the wrong place.");
        }

        [Then(@"One product should have an incorrect image path ""([^""]*)""")]
        public void ThenOneProductShouldHaveAnIncorrectImagePath(string expectedSrc)
        {
            Assert.That(_productsPage.IsFirstInventoryItemImageSrcCorrect(expectedSrc), "The first inventory item image src is incorrect.");
        }
    }
}
