using OpenQA.Selenium;

namespace SwagLabsTestProject.Pom
{
    public class ProductsPage
    {
        private readonly IWebDriver _driver;

        // Define the locator for the inventory items
        private By inventoryItem = By.ClassName("inventory_item");
        private By inventoryItemImage = By.CssSelector("img.inventory_item_img");
        private By cartIcon = By.ClassName("shopping_cart_link");

        // Constructor to initialize the WebDriver
        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to check if the inventory items are displayed
        public bool AreInventoryItemsDisplayed() => _driver.FindElements(inventoryItem).All(item => item.Displayed);
        
        // Method to check if the inventory item image has the expected src
        public bool IsFirstInventoryItemImageSrcCorrect(string expectedSrc)
        {
            var firstImage = _driver.FindElement(inventoryItemImage);
            var x = firstImage.GetAttribute("src");
            return firstImage.GetAttribute("src").Contains(expectedSrc);
        }

        // Method to check if the inventory item image has the expected src
        public bool IsInventoryItemImageSrcCorrect(string expectedSrc)
        {
            var images = _driver.FindElements(inventoryItemImage);
            return images.All(img => img.GetAttribute("src").Contains(expectedSrc));
        }

        // Method to check if the cart icon is in the wrong place
        public bool IsCartIconInWrongPlace()
        {
            var cartIconElement = _driver.FindElement(cartIcon);
            var display = cartIconElement.GetCssValue("display");
            // Check if the cart icon has the expected CSS properties
            return display == "block"; //expected: relative
        }
    }
}
