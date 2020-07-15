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
        public PageFunctions CustomScript(string script, string idOrClass)
        {
            //for any action
            driverclass.ExecuteScript(script, idOrClass);
            return this;
        }
        public PageFunctions AssertText(string xpath, string label, bool shouldBe = true)
        {
            driverclass.AssertTextByXPath(xpath, label, shouldBe);
            return this;
        }
        public PageFunctions TextContains(string xpath, string filter, string[] ignoreChars, bool shouldBe = true)
        {
            driverclass.AssertTextContains(xpath, filter, shouldBe, ignoreChars);
            return this;
        }
        public PageFunctions FillInField(string fieldId, string dataToFill)
        {
            //for specific action
            driverclass.ExecuteScript(Scripts.FillInField, fieldId, dataToFill);
            return this;
        }
        public PageFunctions ClickButtonById(string buttonId)
        {
            driverclass.ExecuteScript(Scripts.ClickButton, buttonId);
            return this;
        }
        public PageFunctions ClickCheckbox(string script, int sectionId, int checkBoxId)
        {
            driverclass.ExecuteScriptByInt(script, sectionId, checkBoxId);
            return this;
        }
        public PageFunctions WaitForCheckbox(string script, int sectionId, int checkboxId)
        {
            driverclass.waitUntilFieldReady(Scripts.IsCheckboxReady, sectionId, checkboxId);
            return this;
        }
        public PageFunctions SubmitForm(string formId)
        {
            driverclass.ExecuteScript(Scripts.SubmitForm, formId);
            return this;
        }
        public PageFunctions ElementDoesNotExist(string xpath)
        {
            driverclass.ElementDoesNotExist(xpath);
            return this;
        }
    }
}
