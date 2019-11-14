using System;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class LandingPage
    {
        private IWebDriver driver;

        private By header = By.TagName("h1");
        private By subHeader = By.ClassName("lead");
        private By signUpButton = By.CssSelector("a[class='btn btn-lg btn-info mr-2']");
        private By loginButton = By.CssSelector("a[class='btn btn-lg btn-light']");

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public String GetHeaderText()
        {
            return driver.FindElement(header).Text;
        }

        public String GetSubHeaderText()
        {
            return driver.FindElement(subHeader).Text;
        }

        public String GetSignUpButtonText()
        {
            return driver.FindElement(signUpButton).Text;
        }

        public String GetLoginButtonText()
        {
            return driver.FindElement(loginButton).Text;
        }

        public void ClickSignUp()
        {
            driver.FindElement(signUpButton).Click();
        }

        public void ClickLogin()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
