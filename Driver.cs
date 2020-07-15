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
        public static IWebDriver driver = new ChromeDriver();
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
        public Driver waitUntilFieldReady(string script, int param1 = 0, int param2 = 0, int param3 = 0)
        {
            int i = 0;
            bool fieldExists = false;
            while(i < 6000)
            {
                fieldExists = ExecuteScriptAndReturn(script, param1, param2, param3);
                if (fieldExists == true)
                {
                    break;
                }
                i++;
            }
            return this;
        }
        public Driver ExecuteScript(string script, string param1 = null, string param2 = null, string param3 = null)
        {
            waitUntilPageLoaded();
            ((IJavaScriptExecutor)driver).ExecuteScript(String.Format(script, param1, param2, param3));
            waitUntilPageLoaded();
            return this;
        }
        public bool ExecuteScriptAndReturn(string script, int param1 = 0, int param2 = 0, int param3 = 0)
        {
            bool returnValue = false;
            try
            {
                waitUntilPageLoaded();
                ExecuteScriptByInt(script, param1, param2);
                waitUntilPageLoaded();
                returnValue = true;
            }
            catch(Exception e)
            {
                returnValue = false;
            }
            return returnValue;

        }
        public Driver ExecuteScriptByInt(string script, int param1 = 0, int param2 = 0, int param3 = 0)
        {
            waitUntilPageLoaded();
            ((IJavaScriptExecutor)driver).ExecuteScript(String.Format(script, param1, param2, param3));
            waitUntilPageLoaded();
            return this;
        }
        public Driver AssertTextByXPath(string xpath, string label, bool shouldBe = true)
        {
            waitUntilPageLoaded();
            String actualString = driver.FindElement(By.XPath(xpath)).Text;
            if (!shouldBe)
            {
                //for negative testing
                Assert.AreNotEqual(actualString, label);
            }
            else
            {
                Assert.AreEqual(actualString, label);
            }
            
            return this;
        }
        public Driver AssertTextContains(string xpath, string label, bool shouldBe = true, string[] ignoreChars = null)
        {
            waitUntilPageLoaded();
            String actualString = driver.FindElement(By.XPath(xpath)).Text;
            foreach (var character in ignoreChars)
            {
                actualString = actualString.Replace(character, " ");
            }
            Assert.IsTrue(actualString.Contains(label));

            return this;
        }
        public Driver ElementDoesNotExist(string xpath)
        {
            try
            {
                driver.FindElement(By.XPath(xpath));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return this;
        }
    }
}
