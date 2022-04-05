using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // The browser
            IWebDriver driver = new ChromeDriver(@"C:\Program Files\Chromedriver");
            driver.Navigate().GoToUrl("https://www.google.com/");
            // The Big Window
            driver.Manage().Window.Maximize();
            // The Element
            IWebElement search = driver.FindElement(By.Name("q"));
            // The Text
            search.SendKeys("India");
            // The Search Key
            IWebElement enter = driver.FindElement(By.Name("btnK"));
            enter.Click();
        }
    }
}
