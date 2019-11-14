using System;
using NUnit.Framework;
using NUnitProject.Model;

namespace NUnitProject.Tests
{
    public class LandingPageTests : BaseTest
    {
        [Test]
        public void Header_HasExpectedText()
        {
            const string expectedHeader = "NQA Social Media Test";

            LandingPage landingPage = new LandingPage(driver);

            Assert.AreEqual(expectedHeader, landingPage.GetHeaderText());
        }

        [Test]
        public void SubHeader_HasExpectedText()
        {
            const string expectedSubHeader = "Create a profile, share posts and test";

            LandingPage landingPage = new LandingPage(driver);

            Assert.AreEqual(expectedSubHeader, landingPage.GetSubHeaderText());
        }

        [Test]
        public void SignUpButton_HasExpectedText()
        {
            const string expectedLabel = "Sign Up";

            LandingPage landingPage = new LandingPage(driver);

            Assert.AreEqual(expectedLabel, landingPage.GetSignUpButtonText());
        }

        [Test]
        public void LoginButton_HasExpectedText()
        {
            const string expectedLabel = "Login";

            LandingPage landingPage = new LandingPage(driver);

            Assert.AreEqual(expectedLabel, landingPage.GetLoginButtonText());
        }
    }
}
