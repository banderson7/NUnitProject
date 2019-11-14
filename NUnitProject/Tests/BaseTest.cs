using System;
using NUnit.Framework;
using NUnitProject.Utility;
using OpenQA.Selenium;

namespace NUnitProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Driver.StartDriver();
            driver.Url = "http://localhost:3000";
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
