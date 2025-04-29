using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Logicals.Programs
{

    public class ActionClass
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUpMethod()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop/");
            _driver.Manage().Window.Maximize();
        }


        [Test]
        public void Test()
        {
            Actions action = new Actions(_driver);

            IWebElement source = _driver.FindElement(By.XPath("//img[@alt = 'The peaks of High Tatras']"));
            IWebElement destination = _driver.FindElement(By.XPath("//div[contains(@class, 'ui-widget-content')]"));

            action.DragAndDrop(source, destination).Perform();
            action.DoubleClick().Perform();
            action.ContextClick().Perform();
            // Scroll to the element
            action.MoveToElement(source).Perform();
            action.ScrollByAmount(0, 500).Perform();

            action.ClickAndHold(source)
                  .MoveToElement(destination)
                  .Release()
                  .Perform();

        }

        public void KeyBoard()
        {
            Actions actions = new Actions(_driver);

            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();

            IWebElement inputField = _driver.FindElement(By.Id("username"));
            inputField.SendKeys(Keys.Backspace);
        }

        [TearDown]
        public void TearDownMethod()
        {
            Thread.Sleep(1000);
            _driver.Quit();
        }


    }
}
