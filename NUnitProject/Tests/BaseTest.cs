using System;
using NUnit.Framework;
using NUnitProject.Utility;
using OpenQA.Selenium;

namespace NUnitProject.Tests
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    public class BaseTest
    {
        protected IWebDriver driver;
        string browser;

        public BaseTest(string browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void Setup()
        {
            driver = Driver.StartDriver(browser);
            driver.Url = "http://localhost:3000";
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
