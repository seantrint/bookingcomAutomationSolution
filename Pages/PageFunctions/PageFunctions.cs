using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.Pages.PageFunctions
{
    public class PageFunctions
    {
        Driver driverclass = new Driver();
        //this class should have generic methods for performing functions against page elements
        //clicking buttons, filling in fields etc.
        //methods for many different pages should call these generic methods specifying different parameters
        public PageFunctions FillInField(string fieldId, string dataToFill)
        {
            //document.getElementById("ss").value = "Johnny Bravo";
            driverclass.waitUntilPageLoaded();
            ((IJavaScriptExecutor)driverclass.driver).ExecuteScript(String.Format("window.document.getElementById('{0}').value = '{1}';", fieldId, dataToFill));
            return this;
        }
        public PageFunctions ClickButton(string buttonId)
        {
            driverclass.waitUntilPageLoaded();
            ((IJavaScriptExecutor)driverclass.driver).ExecuteScript(String.Format("document.getElementById({0}).click();", buttonId));
            return this;
        }
        public PageFunctions SubmitForm(string formId)
        {
            driverclass.waitUntilPageLoaded();
            ((IJavaScriptExecutor)driverclass.driver).ExecuteScript(String.Format("document.getElementById({0}).submit();", formId));
            return this;
        }
    }
}
