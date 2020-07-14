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
            string script = "window.document.getElementById('{0}').value = '{1}';";

            driverclass.ExecuteScript(script, fieldId, dataToFill);
            return this;
        }
        public PageFunctions ClickButton(string buttonId)
        {
            string script = "document.getElementById('{0}').click();";

            driverclass.ExecuteScript(script, buttonId);
            return this;
        }
        public PageFunctions SubmitForm(string formId)
        {
            string script = "document.getElementById('{0}').submit();"; // get scripts from model file

            driverclass.ExecuteScript(script, formId);
            return this;
        }
    }
}
