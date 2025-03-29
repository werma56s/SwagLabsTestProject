using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
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
            _scenarioContext.TryGetValue("Browser", out var browser);
            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;
                case "Firefox":
                    //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"H:\C#\Testy_automatyczne\Test_Project_Selenium_Helion\Test_Project_Selenium_Helion\Driver", "geckodriver.exe");
                    //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    _driver = new FirefoxDriver();//service
                    break;
                case "Edge":
                    _driver = new EdgeDriver();
                    break;
            }
            _driver.Manage().Cookies.DeleteAllCookies();

            _container.RegisterInstanceAs<IWebDriver>(_driver);
            _scenarioContext.ScenarioContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}