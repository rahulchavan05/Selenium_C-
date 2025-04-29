using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Allure.Commons;


namespace Logicals.Selenium
{
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(EdgeDriver))]
    [Parallelizable]

    internal class BrowParallal <Multi> where Multi : IWebDriver , new()
    {
        private IWebDriver _driver;

        [Test]
        public void Parallal()
        {
            _driver = new Multi();

            _driver.Navigate().GoToUrl("https://www.google.com/");
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("APjFqb")).SendKeys("Flipkart");
            //_driver.FindElement(By.Name("btnK")).Click();

            Thread.Sleep(6000);

            _driver.Quit();

        }
    }
}
