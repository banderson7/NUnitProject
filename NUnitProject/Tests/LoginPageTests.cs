using System;
using NUnit.Framework;
using NUnitProject.Data;
using NUnitProject.Model;
using NUnitProject.Model.Page;

namespace NUnitProject.Tests
{
    public class LoginPageTests : BaseTest
    {
        public LoginPageTests(string browser) : base(browser)
        {
        }

        [Test]
        public void Submit_EmptyEmailError()
        {
            const string expectedError = "Email is required";
            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            loginPage.ClickSubmit();

            Assert.AreEqual(expectedError, loginPage.GetEmailError());
        }

        [Test]
        public void Submit_EmptyPasswordError()
        {
            const string expectedError = "Password is required";

            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            loginPage.ClickSubmit();

            Assert.AreEqual(expectedError, loginPage.GetPasswordError());
        }

        [Test]
        public void Submit_InvalidEmailFormatError()
        {
            const string expectedError = "Email is invalid";

            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            loginPage.EnterEmail("invalid")
                .ClickSubmit();

            Assert.AreEqual(expectedError, loginPage.GetEmailError());
        }

        [Test]
        public void Submit_AccountDoesNotExistError()
        {
            const string expectedError = "User not found";

            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            loginPage.EnterUsernamePassword(Users.InvalidUser)
                .ClickSubmit();

            Assert.AreEqual(expectedError, loginPage.GetEmailError());
        }

        [Test]
        public void Submit_IncorrectPasswordError()
        {
            const string expectedError = "Password is incorrect";

            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            loginPage.EnterUsernamePassword(Users.IncorrectPasswordUser)
                .ClickSubmit();

            Assert.AreEqual(expectedError, loginPage.GetPasswordError());
        }

        [Test]
        public void Submit_SuccessfulLogin()
        {
            LandingPage landingPage = new LandingPage(driver);

            LoginPage loginPage = landingPage.ClickLogin();
            DashboardPage dashboardPage =
                loginPage.EnterUsernamePassword(Users.ValidUser)
                .ClickSubmit();

            Assert.True(dashboardPage.IsDashboardDisplayed());
        }
    }
}
