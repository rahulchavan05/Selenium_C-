using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Selenium
{
    internal class VerifyElementSelected
    {
        public void Selected()
        {
            IWebDriver _driver = new ChromeDriver();

            IWebElement el = _driver.FindElement(By.Id("id"));

            bool result = el.Selected;

            SelectElement drop = new SelectElement(_driver.FindElement(By.Id("id")));

            // bool re2 = drop.SelectedOption;

            // Displayed                // for windows 

            // bool isElementPresent = IsElementPresent(driver, By.Id("loginButton"));
        }

        
    }
}
