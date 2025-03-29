using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Pom
{
    public class Navigation
    {
        private readonly IWebDriver _driver;

        // Constructor to initialize the WebDriver
        public Navigation(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to navigate to a specified URL
        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
