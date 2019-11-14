using System;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class LoginPage : BasePage
    {
        private By loginForm = By.ClassName("login");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoginFormDisplayed()
        {
            return driver.FindElement(loginForm).Displayed;
        }
    }
}
