using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logicals.Selenium
{
    internal class SwitchTOWindow
    {
        private IWebDriver _driver;

        [Test]
        public void HandleWindow()
        {
            _driver = new FirefoxDriver();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
            _driver.FindElement(By.XPath("//a[@class = 'external-link']")).Click();
            _driver.Manage().Window.Maximize();

            Console.WriteLine("Window ID = " + _driver.CurrentWindowHandle);

            _driver.SwitchTo().Window(_driver.WindowHandles[1]);

            Console.WriteLine("Window ID = "+_driver.CurrentWindowHandle);
            Thread.Sleep(2000);
            Console.WriteLine(_driver.FindElement(By.XPath("(//a[contains(text(), 'Library')])[2]")).Text);


            _driver.Quit();

        }
    }
}
