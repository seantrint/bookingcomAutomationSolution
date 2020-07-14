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
        public const string ClickCheckInDate = "document.getElementsByClassName('bui-calendar__date')[17].click()"; //should have better solution for this - probably works in all cases but may not
        public const string ClickCheckOutDate = "document.getElementsByClassName('bui-calendar__date')[20].click()"; //should have better solution for this - probably works in all cases but may not
    }
}
