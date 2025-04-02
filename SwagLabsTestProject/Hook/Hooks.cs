using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Communication;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SwagLabsTestProject.Drivers;
using TechTalk.SpecFlow;

namespace SwagLabsTestProject.Hook
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            this._container = container;
            this._scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Pobieramy nazwę przeglądarki z tagu @Browser w Feature
            _scenarioContext.TryGetValue("Browser", out var browser);

            // Jeśli nie ma wartości przeglądarki, domyślnie ustawiamy 'Chrome'
            if (string.IsNullOrEmpty(browser?.ToString()))
            {
                browser = "chrome";
            }

            // Tworzymy instancję WebDriverLibrary i uruchamiamy WebDriver
            WebDriverLibrary webDriverLibrary = new WebDriverLibrary(_scenarioContext);
            var driver = webDriverLibrary.Setup(browser.ToString()); // Uruchamiamy Selenium Grid
            _scenarioContext.Set(driver, "WebDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();

            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}