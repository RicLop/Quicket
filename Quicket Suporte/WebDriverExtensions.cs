using OpenQA.Selenium;
using System;

namespace Quicket.Rules
{
    public static class WebDriverExtensions
    {
        public static void CarregarPagina(this IWebDriver webDriver, TimeSpan timeToWait, string url)
        {
            webDriver.Manage().Timeouts().PageLoad = timeToWait;
            webDriver.Navigate().GoToUrl(url);
        }

        public static void Clicar(this IWebDriver webDriver, By by) =>
            webDriver.FindElement(by).Click();

        public static string ObterTexto(this IWebDriver webDriver, By by) =>
            webDriver.FindElement(by).Text;

        public static void AtribuirTexto(this IWebDriver webDriver, By by, string text) =>
            webDriver.FindElement(by).SendKeys(text);

        public static void Enviar(this IWebDriver webDriver, By by) =>
            webDriver.FindElement(by).Submit();
    }
}