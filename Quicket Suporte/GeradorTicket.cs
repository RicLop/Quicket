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

        public void CarregarPagina(string nomeCliente, string assunto, ref bool logado)
        {
            _driver.CarregarPagina(TimeSpan.FromSeconds(120), "https://mestresistemas.movidesk.com/");

            logado = logado != true ? false : true;
            if (!logado)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(200));
                wait.Until(ExpectedConditions.ElementExists(By.Id("button-more-icon-container")));

                logado = true;
            }

            try
            {
                _driver.FindElement(By.CssSelector(".active.tab-li")).Click();
            }
            catch (Exception) { }

            var keyAction = new Actions(_driver);
            keyAction.KeyDown(Keys.Alt).SendKeys("T").KeyUp(Keys.Alt).Perform();

            var element = _driver.FindElement(By.CssSelector(".active.tab-li"));
            var tabId = (string)element.GetAttribute("id").Replace("tab", "");

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));

            var ticketNumero = (string)element.GetAttribute("data-md-original-title").Split(' ')[0];

            element = _driver.FindElement(By.XPath($"//*[@id='tab-pane{tabId}']/div/div[1]/section/form/input[68]"));
            var ticketId = (string)element.GetAttribute("id").Replace("informAtLeastOneRelationship", "");            

            element = _driver.FindElement(By.CssSelector($"#subject-{ticketNumero}"));
            element.SendKeys(assunto);

            if (!string.IsNullOrWhiteSpace(nomeCliente))
            {
                element = _driver.FindElement(By.CssSelector($"#description-{ticketId}_ifr"));
                element.SendKeys($" Conforme conversado com {nomeCliente}, ");
            }
        }
    }
}