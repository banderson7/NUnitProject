using System;
using NUnitProject.Model.Objects;
using NUnitProject.Model.Page;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class LoginPage : BasePage
    {
        private By loginForm = By.ClassName("login");
        private By emailField = By.Id("email");
        private By passwordField = By.Id("password");
        private By submitButton = By.CssSelector("input[class='btn btn-info btn-block mt-4']");
        private By emailError = By.Id("emailError");
        private By passwordError = By.Id("passwordError");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoginFormDisplayed() => IsDisplayed(loginForm);

        public string GetEmailError() => GetText(emailError);

        public string GetPasswordError() => GetText(passwordError);

        public LoginPage EnterUsernamePassword(User user)
        {
            SendKeys(emailField, user.Email);
            SendKeys(passwordField, user.Password);
            return this;
        }

        public LoginPage EnterEmail(string email)
        {
            SendKeys(emailField, email);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            SendKeys(passwordField, password);
            return this;
        }

        public DashboardPage ClickSubmit()
        {
            Click(submitButton);
            return new DashboardPage(driver);
        }
    }
}
