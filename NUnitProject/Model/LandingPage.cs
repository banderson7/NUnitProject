using System;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class LandingPage : BasePage
    {

        private By header = By.TagName("h1");
        private By subHeader = By.ClassName("lead");
        private By signUpButton = By.CssSelector("a[class='btn btn-lg btn-info mr-2']");
        private By loginButton = By.CssSelector("a[class='btn btn-lg btn-light']");

        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        public String GetHeaderText() => driver.FindElement(header).Text;

        public String GetSubHeaderText() => driver.FindElement(subHeader).Text;

        public String GetSignUpButtonText() => driver.FindElement(signUpButton).Text;
        
        public String GetLoginButtonText() => driver.FindElement(loginButton).Text;

        public SignUpPage ClickSignUp()
        {
            driver.FindElement(signUpButton).Click();
            return new SignUpPage(driver);
        }

        public LoginPage ClickLogin()
        {
            driver.FindElement(loginButton).Click();
            return new LoginPage(driver);
        }
    }
}
