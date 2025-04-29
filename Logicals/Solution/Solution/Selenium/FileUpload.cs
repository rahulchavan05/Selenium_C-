using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logicals.Selenium
{
    internal class FileUpload
    {
        private IWebDriver _driver;
        [Test]
        public void UploadFile()
        {
            _driver = new ChromeDriver();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
            _driver.Manage().Window.Maximize();
            IWebElement fileupload = _driver.FindElement(By.XPath("//input[@id = 'picture']"));

            Thread.Sleep(3000);
            fileupload.SendKeys("C:\\Users\\rahul\\Downloads\\Rahul_Chavan_Automation_Tester.pdf");
            Thread.Sleep(6000);

            //AutoItX3 a = new AutoItX3();
            //a.WinActive("Windwow name");

            //a.Send("File Path");
            //a.Send("{ENTER}");

            _driver.Quit();

        }
    }
}
