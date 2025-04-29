using Allure.Commons;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.AllureReport
{
    internal class AllureUtility
    {
        public static void AttachAllureScreenshot(IWebDriver driver)
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                byte[] content = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
                AllureLifecycle.Instance.AddAttachment("Faild Screenshot","image/png",content);

            }
        }
    }
}
