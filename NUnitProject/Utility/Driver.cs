using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace NUnitProject.Utility
{
    public static class Driver
    {
        public static IWebDriver StartDriver(string browser)
        {
            if (browser == "chrome")
                return new ChromeDriver();
            if (browser == "firefox")
                return new FirefoxDriver();
            else
                return new ChromeDriver();
        }
    }
}
