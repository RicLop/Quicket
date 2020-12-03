using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace Quicket.Rules
{
    public static class WebDriverFactory
    {
        public static IWebDriver CriarWebDriver(string pathDriver)
        {
            var options = new EdgeOptions();

            options.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;

            var driverService = EdgeDriverService.CreateDefaultService(pathDriver);

            return new EdgeDriver(driverService, options);
        }
            
    }
}