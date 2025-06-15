using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart_Automation.Pages
{
    internal class LoginPages
    {
        IWebDriver _driver;
        public LoginPages(IWebDriver driver)
        {
            this._driver = driver;
        }

        private IWebElement CloseLoginPopUp => _driver.FindElement(By.ClassName("_30XB9F"));

        // Update these selectors as per your actual HTML
        private IWebElement LoginButton => _driver.FindElement(By.ClassName("H6-NpN"));
        private By DropdownLocator => By.CssSelector("div._1Us3XD");
        private By SignUpButtonLocator => By.ClassName("_1Mikcj");

        private By PhoneInputLocator => By.ClassName("r4vIwl");


        public void ClosePupUpIfPresent()
        {
            try
            {
                if (CloseLoginPopUp.Displayed)
                {
                    CloseLoginPopUp.Click();
                }
            }
            catch
            {

            }
        }

        public void ClickSignUpAfterDropdown()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(LoginButton).Perform();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(DropdownLocator).Displayed);
            IWebElement signUpButton = _driver.FindElement(SignUpButtonLocator);
            signUpButton.Click();
        }

        public void EnterContactNumberAndSubmit(string contactNumber)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            // Wait for the phone input to be visible
            wait.Until(driver => driver.FindElement(PhoneInputLocator).Displayed);

            // Enter the contact number
            _driver.FindElement(PhoneInputLocator).SendKeys(contactNumber);

            // Click the submit button
            _driver.FindElement(By.ClassName("QqFHMw")).Click();
        }

        public void ClickCartSection()
        {         
            IWebElement cartSection = _driver.FindElement(By.LinkText("Cart")); 
            cartSection.Click();
        }
    }
}
