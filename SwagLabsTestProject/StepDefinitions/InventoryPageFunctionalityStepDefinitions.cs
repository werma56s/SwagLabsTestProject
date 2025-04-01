using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsTestProject.Pom;
using System;
using TechTalk.SpecFlow;

namespace SwagLabsTestProject.StepDefinitions
{
    [Binding]
    public class InventoryPageFunctionalityStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly InventoryPage _inventoryPage;
        private readonly CartPage _cartPage;

        public InventoryPageFunctionalityStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _inventoryPage = new InventoryPage(driver);
            _cartPage = new CartPage(driver);
        }

        [When(@"User clicks on the ""([^""]*)"" button of a product ""([^""]*)""")]
        public void WhenUserClicksOnTheButtonOfAProduct(string button, string productName)
        {
            _inventoryPage.ClickProductButton(productName, button);
        }

        [Then(@"The product should be added to the cart")]
        public void ThenTheProductShouldBeAddedToTheCart()
        {
            Assert.That(_inventoryPage.IsCartBadgeDisplayed());
        }

        [Then(@"The cart badge should show the correct item count")]
        public void ThenTheCartBadgeShouldShowTheCorrectItemCount()
        {
            Assert.That(_inventoryPage.GetCartBadgeCount(), Is.EqualTo(1));
        }

        [When(@"User clicks on the ""([^""]*)"" button for that product ""([^""]*)""")]
        public void WhenUserClicksOnTheButtonForThatProduct(string remove, string productName)
        {
            _inventoryPage.RemoveProductFromCart(productName);
        }

        [Then(@"The product should be removed from the cart")]
        public void ThenTheProductShouldBeRemovedFromTheCart()
        {
            Assert.That(_cartPage.GetCartItemCount(), Is.EqualTo(0));
        }

        [Then(@"The cart badge should update correctly")]
        public void ThenTheCartBadgeShouldUpdateCorrectly()
        {
            Assert.That(_inventoryPage.GetCartBadgeCount(), Is.EqualTo(0));
        }

        [When(@"User navigates to the cart page")]
        public void WhenUserNavigatesToTheCartPage()
        {
            _inventoryPage.NavigateToCart();
        }

        [Then(@"The cart should display exactly two products ""([^""]*)"" and ""([^""]*)""")]
        public void ThenTheCartShouldDisplayExactlyTwoProductsAnd(string product1, string product2)
        {
            var products = _cartPage.GetCartProductNames();
            Assert.That(products.Count == 2 && products.Contains(product1) && products.Contains(product2));
        }

        [When(@"User selects ""([^""]*)"" from the sorting dropdown")]
        public void WhenUserSelectsFromTheSortingDropdown(string option)
        {
            _inventoryPage.SortProducts(option);
        }

        [Then(@"The products should be sorted from the lowest to the highest price")]
        public void ThenTheProductsShouldBeSortedFromTheLowestToTheHighestPrice()
        {
            Assert.That(_inventoryPage.AreProductsSortedByPriceAscending());
        }

        [Then(@"The products should be sorted from the highest to the lowest price")]
        public void ThenTheProductsShouldBeSortedFromTheHighestToTheLowestPrice()
        {
            Assert.That(_inventoryPage.AreProductsSortedByPriceDescending());
        }

        [Then(@"The products should be sorted from the A to the Z name")]
        public void ThenTheProductsShouldBeSortedFromTheAToTheZName()
        {
            Assert.That(_inventoryPage.AreProductsSortedByNameAscending());
        }

        [Then(@"The products should be sorted from the Z to the A name")]
        public void ThenTheProductsShouldBeSortedFromTheZToTheAName()
        {
            Assert.That(_inventoryPage.AreProductsSortedByNameDescending());
        }

        [When(@"User clicks on the menu button")]
        public void WhenUserClicksOnTheMenuButton()
        {
            _inventoryPage.ClickMenuButton();
        }

        [When(@"User selects the ""([^""]*)"" option")]
        public void WhenUserSelectsTheOption(string option)
        {
            _inventoryPage.SelectMenuOption(option);
        }

        [Then(@"User should be redirected to the login page")]
        public void ThenUserShouldBeRedirectedToTheLoginPage()
        {
            Assert.That(_inventoryPage.IsOnLoginPage());
        }
    }
}
