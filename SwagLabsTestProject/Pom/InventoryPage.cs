using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Pom
{
    public class InventoryPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement CartBadge
        {
            get
            {
                try
                {
                    return _driver.FindElement(By.ClassName("shopping_cart_badge"));
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        private IWebElement SortingDropdown => _driver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement MenuButton => _driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement LogoutLink => _driver.FindElement(By.Id("logout_sidebar_link"));
        private IWebElement CartIcon => _driver.FindElement(By.ClassName("shopping_cart_link"));

        public void ClickProductButton(string productName, string buttonType)
        {
            var product = _driver.FindElement(By.XPath($"//div[text()='{productName}']/ancestor::div[@class='inventory_item']//button[contains(text(), '{buttonType}')]"));
            product.Click();
        }

        public bool IsCartBadgeDisplayed()
        {
            return CartBadge.Displayed;
        }

        public int GetCartBadgeCount()
        {
            return CartBadge != null && int.TryParse(CartBadge.Text, out var count) ? count : 0;
        }

        public void RemoveProductFromCart(string productName)
        {
            ClickProductButton(productName, "Remove");
        }

        public void NavigateToCart()
        {
            CartIcon.Click();
        }

        public void SortProducts(string sortOption)
        {
            var selectElement = new SelectElement(SortingDropdown);
            selectElement.SelectByText(sortOption);
        }

        public bool AreProductsSortedByPriceAscending()
        {
            var prices = _driver.FindElements(By.ClassName("inventory_item_price"))
                                .Select(e => Convert.ToDouble(e.Text.Replace("$", "")))
                                .ToList();
            return prices.SequenceEqual(prices.OrderBy(p => p));
        }

        public bool AreProductsSortedByPriceDescending()
        {
            var prices = _driver.FindElements(By.ClassName("inventory_item_price"))
                                .Select(e => Convert.ToDouble(e.Text.Replace("$", "")))
                                .ToList();
            return prices.SequenceEqual(prices.OrderByDescending(p => p));
        }

        public bool AreProductsSortedByNameAscending()
        {
            var names = _driver.FindElements(By.ClassName("inventory_item_name"))
                               .Select(e => e.Text)
                               .ToList();
            return names.SequenceEqual(names.OrderBy(n => n));
        }

        public bool AreProductsSortedByNameDescending()
        {
            var names = _driver.FindElements(By.ClassName("inventory_item_name"))
                               .Select(e => e.Text)
                               .ToList();
            return names.SequenceEqual(names.OrderByDescending(n => n));
        }

        public void ClickMenuButton()
        {
            MenuButton.Click();
        }

        public void SelectMenuOption(string option)
        {
            if (option == "Logout")
            {
                // Czekanie na zakończenie ładowania strony
                _wait.Until(d => ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").ToString() == "complete");

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
                jsExecutor.ExecuteScript("arguments[0].click();", LogoutLink);
            }
        }

        public bool IsOnLoginPage()
        {
            return _driver.FindElement(By.ClassName("login_container")).Displayed;
        }
    }
}
