﻿using System;
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
        public const string FirstSearchResultLink = "sr-hotel__name";
        public const string LowestPriceFirstButton = " sort_category   sort_price ";
        public const string SelectedCheckBox = "filteroptions filter_selected";
        public const string HotelStarRatingXPath = "/html/body/div[6]/div/div[3]/div[1]/div[1]/div[7]/div[3]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div[1]/span/i/span";

        public const string StarRatingLabel = "filter_class";
        public const string StarRatingLabelXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[1]/h3";
        public const string FirstStarXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[1]/label/div/span[1]";
        public const string SecondStarXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[2]/label/div/span[1]";
        public const string ThirdStarXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[3]/label/div/span[1]";
        public const string FourthStarXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[4]/label/div/span[1]";
        public const string FifthStarXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[5]/label/div/span[1]";
        public const string UnratedXPathLabel = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[5]/div[2]/a[6]/label/div/span[1]";
        public const int StarRatingSectionId = 3;
        public const int FirstStarCheckboxId = 0;
        public const int SecondStarCheckboxId = 1;
        public const int ThirdStarCheckboxId = 2;
        public const int FourthStarCheckboxId = 3;
        public const int FifthStarCheckboxId = 4;
        public const int UnratedCheckboxId = 5;

        public const string SpaLabelXPath = "/html/body/div[6]/div/div[3]/div[1]/div[2]/div[1]/div[5]/form/fieldset/div[1]/div/div[9]/div[2]/a[2]/label/div/span[1]";
        public const int FunThingsSectionId = 7;
        public const int SpaCheckboxId = 1;

    }
}
