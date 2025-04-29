using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;


namespace Logicals.AllureReport
{
    [Parallelizable]
    internal class LoginPage
    {


        [TestFixture]
        [AllureNUnit]  // Enables Allure reporting for this test class
        [AllureSuite("Login Tests")]
        [AllureFeature("User Authentication")]
        public class LoginTests
        {

            [SetUp]
            public void setup()
            {
                _driver = new ChromeDriver();

                _driver.Navigate().GoToUrl("https://www.google.com/");
                _driver.Manage().Window.Maximize();
            }

            private IWebDriver _driver;
            [Test]
            [AllureStory("Valid Login")]
            [AllureOwner("Rahul")]
            [AllureTag("Regression", "Smoke")]
            [AllureDescription("This test verifies that a user can log in with valid credentials.")]
            public void ValidLoginTest()
            {
                _driver.FindElement(By.Id("APjFqb")).SendKeys("Flipkart");   // Test
            } 

            [Test]
            [AllureStory("Invalid Login")]
            public void InvalidLoginTest()
            {  
                _driver.FindElement(By.Id("APjFqbs")).SendKeys("Flipkart");    // Test
            }

            [TearDown]
            public void TearDown()
            {
                AllureUtility.AttachAllureScreenshot(_driver);
                _driver.Quit();

            }
        }
    }
}
