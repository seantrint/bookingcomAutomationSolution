using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.TestData
{
    public static class Scripts
    {
        //HomePage
        public const string ClickButton = "document.getElementById('{0}').click();";
        public const string FillInField = "window.document.getElementById('{0}').value = '{1}';";
        public const string SubmitForm = "document.getElementById('{0}').submit();";
        public const string ClickCheckIn = "document.getElementsByClassName('{0}')[1].click()";
        public const string ClickCalendarNextPrevious = "document.getElementsByClassName('{0}')[0].click()";
        public const string ClickCheckInDate = "document.getElementsByClassName('bui-calendar__date')[17].click()";
        public const string ClickCheckOutDate = "document.getElementsByClassName('bui-calendar__date')[20].click()";
        public const string ClickFilterCheckbox = "document.getElementsByClassName('filteroptions')[{0}].children[{1}].click()"; //this will work for any checkbox on this page but have to know which one is which by number
    }
}
