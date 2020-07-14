using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using bookingComAutomationSolution.TestData;

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
            driverclass.ExecuteScript(Scripts.FillInField, fieldId, dataToFill);
            return this;
        }
        public PageFunctions ClickButtonById(string buttonId)
        {
            driverclass.ExecuteScript(Scripts.ClickButton, buttonId);
            return this;
        }
        public PageFunctions ClickButtonByClass(string script, string buttonClass)
        {
            driverclass.ExecuteScript(script, buttonClass);
            return this;
        }
        public PageFunctions SubmitForm(string formId)
        {
            driverclass.ExecuteScript(Scripts.SubmitForm, formId);
            return this;
        }
    }
}
