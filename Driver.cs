using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace bookingComAutomationSolution
{
    public class Driver
    {
        string path = "C:/Users/Sean/Desktop/projects/testautomation/bookingComAutomationSolution/Lib";
        public IWebDriver driver = new ChromeDriver();
        public Driver MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
            waitUntilPageLoaded(); //we can maximize page without caring about loading but after maximizing we need to wait
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
        public Driver waitUntilPageLoaded()
        {
            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            return this;
        }
        public Driver FillInField(string fieldId, string dataToFill)
        {
            //document.getElementById("ss").value = "Johnny Bravo";
            waitUntilPageLoaded();
            ((IJavaScriptExecutor)driver).ExecuteScript(String.Format("document.getElementById('{0}').value = '{1}';", fieldId, dataToFill));
            return this;
        }
        public Driver SubmitForm(string formId, string fieldId, string dataToFill)
        {
            waitUntilPageLoaded();
            FillInField(fieldId, dataToFill);
            ((IJavaScriptExecutor)driver).ExecuteScript(String.Format("document.getElementById('{0}').submit();", formId));
            return this;
        }
        public Driver ClickSubmitButton(string formId)
        {
            waitUntilPageLoaded();
            ((IJavaScriptExecutor)driver).ExecuteScript(String.Format("document.getElementById('{0}').submit();", formId));
            return this;
        }
    }
}
