using System;
using OpenQA.Selenium;

namespace NUnitProject.Model.Page
{
    public class DashboardPage : BasePage
    {
        private By dashboard = By.ClassName("dashboard");

        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsDashboardDisplayed() => IsDisplayed(dashboard);
    }
}
