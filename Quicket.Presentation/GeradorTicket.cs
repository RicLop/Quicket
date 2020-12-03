using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicket.Rules
{
    public class GeradorTicket
    {
        private static IWebDriver _driver;

        public GeradorTicket(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CarregarPagina(string assunto, ref bool logado)
        {   
            _driver.CarregarPagina(TimeSpan.FromSeconds(120), "https://mestresistemas.movidesk.com/");

            var botaoNovo = By.Id("button-more-icon-container");
            var novoTicket = By.ClassName("new-ticket");

            logado = logado != true ? false : true;
            if (!logado)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(200));
                wait.Until(ExpectedConditions.ElementExists(botaoNovo));

                logado = true;
            }

            var keyAction = new Actions(_driver);
            keyAction.KeyDown(Keys.Alt).SendKeys("T").KeyUp(Keys.Alt).Perform();

            var element = _driver.FindElement(By.CssSelector(".active.tab-li"));
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            var tabName = (string)element.GetAttribute("data-original-title").Split(" ")[0];

            element = _driver.FindElement(By.CssSelector($"#subject-{tabName}"));

            element.SendKeys(assunto);
        }
    }
}
