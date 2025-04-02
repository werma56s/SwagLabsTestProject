using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsTestProject.Drivers
{
    internal class WebDriverLibrary
    {
        private readonly ScenarioContext _scenarioContext;
        public RemoteWebDriver driver;
        public WebDriverLibrary(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup(string browserName)
        {
            dynamic capability = GetBrowserOption(browserName);
            // Uruchomienie RemoteWebDriver połączonego z Selenium Grid
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability.ToCapabilities());
            _scenarioContext.Set(driver, "WebDriver");
            return driver;
        }

        private dynamic GetBrowserOption(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    return new ChromeOptions();
                case "firefox":
                    return new FirefoxOptions();
                case "edge":
                    return new EdgeOptions();
                // Dodaj Safari, jeśli wymagasz wsparcia dla tej przeglądarki
                case "safari":
                    return new SafariOptions();
                default:
                    return new ChromeOptions(); // Jeśli nie podano przeglądarki, domyślnie wybierz Chrome
            }
        }

    }
}
