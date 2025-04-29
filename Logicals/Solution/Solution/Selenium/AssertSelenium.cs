using DocumentFormat.OpenXml.Bibliography;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Logicals.Selenium
{
    internal class AssertSelenium
    {
        IWebDriver driver;

        [Test]
        public void AssertAll()
        {
            //Assert.AreEquals("expected", "actual");  // Verifies if two values are equal
            //Assert.AreNotEqual("expected", "actual"); // Verifies if two values are NOT equal
            //Assert.IsTrue("condition");  // Verifies if the condition is true
            //Assert.IsFalse("condition"); // Verifies if the condition is false
            //Assert.IsNull("obj");   // Verifies if the object is null
            //Assert.IsNotNull("obj");  // Verifies if the object is NOT null

            //Assert.AreEquals("expectedTitle", "actualTitle", "Title does not match!");

            Assert.That("Hello World", Does.Contain("World"));  // Check if string contains substring
            Assert.That("Hello World", Does.StartWith("Hello")); // Check if string starts with value
            Assert.That("Hello World", Does.EndWith("World")); // Check if string ends with value

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.That(numbers, Contains.Item(3), "List does not contain expected value.");  // Check if a value exists in the collection
            Assert.That(numbers, Has.Exactly(5).Items);  // Verify collection size
            Assert.That(numbers, Is.Ordered); // Verify collection is sorted

            // Exception Handling Assertions

            Assert.Throws<InvalidOperationException>(() => SomeMethod());
            Assert.DoesNotThrow(() => SomeMethod());
        }

        void SomeMethod()
        {
            throw new InvalidOperationException("Error occurred");
        }

        [Test]
        public void VerifyMultipleConditions()
        {
            string title = driver.Title;
            string url = driver.Url;

            Assert.Multiple(() =>
            {
                //Assert.AreEqual("Google", title, "Title mismatch!");
                //Assert.IsTrue(url.Contains("google"), "URL does not contain 'google'");
            });
        }
    }
}
