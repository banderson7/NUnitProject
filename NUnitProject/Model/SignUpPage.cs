using System;
using OpenQA.Selenium;

namespace NUnitProject.Model
{
    public class SignUpPage : BasePage
    {
        private By registerForm = By.ClassName("register");

        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsRegisterFormDisplayed()
        {
            return IsDisplayed(registerForm);
        }
    }
}
