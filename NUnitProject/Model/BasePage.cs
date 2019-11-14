using System;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
