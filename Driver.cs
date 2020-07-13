using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace bookingComAutomationSolution
{
    public class Driver
    {
        public IWebDriver driver = new ChromeDriver("C:/Users/Sean/Desktop/projects/testautomation/bookingComAutomationSolution/Lib");
        public Driver MaximizeWindow()
        {
            //((IJavaScriptExecutor)driver).ExecuteScript("window.resizeTo(1920, 1080);");
            driver.Manage().Window.Maximize();
            return this;
        }
        public Driver startApplication()
        {
            driver.Url = "https://www.booking.com"; //get this from app.config later
            return this;
        }
        [TearDown]
        public Driver closeBrowser()
        {
            driver.Close();
            return this;
        }
    }
}
