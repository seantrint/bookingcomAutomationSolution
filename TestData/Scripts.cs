using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.TestData
{
    public static class Scripts
    {
        public const string ClickButton = "document.getElementById('{0}').click();";
        public const string FillInField = "window.document.getElementById('{0}').value = '{1}';";
        public const string SubmitForm = "document.getElementById('{0}').submit();";
    }
}
