using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.TestData
{
    public static class PageElementIds
    {
        //Home Page
        public const string HomePageDestinationFieldId = "ss";
        public const string HomePageFormId = "frm";
        public const string CheckInClassName = "xp__dates-inner";
        public const string CalendarNextButton = "bui-calendar__control bui-calendar__control--next";
        public const string CalendarPreviousButton = "bui-calendar__control bui-calendar__control--prev";
        public const string PickableDate = "bui-calendar__date";

        //Search Results Page
        public const string StarRatingLabel = "filter_class";
        public const string StarRatingLabelXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[1]/h3";
        public const string OneStarXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[1]/label/div/span[1]";
        public const string TwoStarXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[2]/label/div/span[1]";
        public const string ThreeStarXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[3]/label/div/span[1]";
        public const string FourStarXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[4]/label/div/span[1]";
        public const string FiveStarXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[5]/label/div/span[1]";
        public const string UnratedXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[6]/label/div/span[1]";


    }
}
