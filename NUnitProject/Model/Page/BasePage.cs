using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitProject.Model
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void Click(By by)
        {
            WaitForElement(by).Click();
        }

        protected bool IsDisplayed(By by)
        {
            return WaitForElement(by).Displayed;
        }

        protected string GetText(By by)
        {
            return WaitForElement(by).Text.Trim();
        }

        protected void SendKeys(By by, string text)
        {
            WaitForElement(by).SendKeys(text);
        }

        private IWebElement WaitForElement(By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait.Until(x => x.FindElement(by));
        }
    }
}
