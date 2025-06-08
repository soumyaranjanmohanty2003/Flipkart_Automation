using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart_Automation.Drivers
{
    public class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if(_driver == null)
            {
               _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void CloseDriver()
        {
           _driver.Close();
        }
    }
}
