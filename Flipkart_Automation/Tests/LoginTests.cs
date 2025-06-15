using Flipkart_Automation.Drivers;
using Flipkart_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Flipkart_Automation.Tests
{
    internal class LoginTests
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.GetDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
        }

        [Test]
        public void CloseLoginPopUpTest()
        {
            var loginPage = new LoginPages(driver);
            Thread.Sleep(2000);
            loginPage.ClosePupUpIfPresent();
            loginPage.ClickSignUpAfterDropdown();
            loginPage.EnterContactNumberAndSubmit("7008773642");
            Thread.Sleep(2000);
        }
        [Test]
        public void CheckCartSection()
        {
            var loginPage = new LoginPages(driver);
            Thread.Sleep(2000);
            loginPage.ClosePupUpIfPresent();
            loginPage.ClickCartSection();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void TearDown()
        {
            DriverFactory.CloseDriver();
        }
    }
}
