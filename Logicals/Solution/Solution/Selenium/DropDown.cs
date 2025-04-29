using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace Logicals.Selenium
{
    internal class DropDown : Utility.Utility
    {

        private IWebDriver _driver;
        [Test]
        public void Dropdown()
        {
            _driver = new FirefoxDriver();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
            _driver.Manage().Window.Maximize();

            IWebElement state = _driver.FindElement(By.Id("state"));

//======================================================================================
            SelectElement select = new SelectElement(state);

            select.SelectByText("Uttar Pradesh");
            select.SelectByIndex(1);
            select.SelectByValue("Haryana");

            Thread.Sleep(3000);
            Utility.Utility.NormalScreenshot(_driver, "D:\\Screenshot\\3");

            _driver.Quit();

        }
    }
}
