using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Teste_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://pt.wikipedia.org/wiki/Wikipédia:Página_principal");
            driver.FindElement(By.Name("search")).SendKeys("pato");
            driver.FindElement(By.Name("go")).Click();
            
        }
    }
}
