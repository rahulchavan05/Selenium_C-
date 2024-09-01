using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_C_
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Sudo code for setting up Selenium
            //1. Create anew instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            //2. Navigate to the URL

            driver.Navigate().GoToUrl("https://www.google.com/");

            //2a. Maximize the browser window

            driver.Manage().Window.Maximize();
            //3. Find the element

            IWebElement surch = driver.FindElement(By.Name("q"));
            //4. GetType in THe element 
            surch.SendKeys("Selenium");
            //5. Click on the element 
            surch.SendKeys(Keys.Return);

            
        }

        [Test]
        public void EAwebSiteTest() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
            IWebElement loginLink = driver.FindElement(By.LinkText("Login")); 
            loginLink.Click();
            IWebElement userName = driver.FindElement(By.Name("UserName"));
            userName.SendKeys("admin");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("password");
            //IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
            //btnLogin.Submit();
            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));
            btnLogin.Submit();


        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(5);
            IWebDriver driver =new ChromeDriver();
            driver.Close();
        }
    }
}