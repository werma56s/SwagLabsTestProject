using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Pom
{
    public class CartPage
    {
        private readonly IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public List<string> GetCartProductNames()
        {
            var productElements = _driver.FindElements(By.ClassName("inventory_item_name"));
            return productElements.Select(e => e.Text).ToList();
        }

        public int GetCartItemCount()
        {
            return GetCartProductNames().Count;
        }

        public bool IsProductInCart(string productName)
        {
            return GetCartProductNames().Contains(productName);
        }

        public void RemoveProduct(string productName)
        {
            var productElements = _driver.FindElements(By.ClassName("cart_item"));
            foreach (var product in productElements)
            {
                if (product.Text.Contains(productName))
                {
                    product.FindElement(By.XPath(".//button[contains(text(), 'Remove')]")).Click();
                    break;
                }
            }
        }

        public void ClickCheckoutButton()
        {
            _driver.FindElement(By.Id("checkout"))?.Click();
        }
    }
}
