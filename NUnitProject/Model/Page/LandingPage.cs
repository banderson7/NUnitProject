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

        public String GetHeaderText() => GetText(header);

        public String GetSubHeaderText() => GetText(subHeader);

        public String GetSignUpButtonText() => GetText(signUpButton);

        public String GetLoginButtonText() => GetText(loginButton);

        public SignUpPage ClickSignUp()
        {
            Click(signUpButton);
            return new SignUpPage(driver);
        }

        public LoginPage ClickLogin()
        {
            Click(loginButton);
            return new LoginPage(driver);
        }
    }
}
