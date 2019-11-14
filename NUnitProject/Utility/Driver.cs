using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace NUnitProject.Utility
{
    public static class Driver
    {
        public static IWebDriver StartDriver()
        {
            return new ChromeDriver();
        }
    }
}
