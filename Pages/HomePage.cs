using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using bookingComAutomationSolution.TestData;
using bookingComAutomationSolution.Pages.PageFunctions;
namespace bookingComAutomationSolution.Pages
{
    //this should have methods for all the different actions available on the home page (although all we care about in this scenario is searching)
    //it should also have a method to go through a main flow i.e. default search values and click button
    //the main flow method will call the other methods we create but use default test data
    //should be able to overload these methods to use different test data and cover many test cases
    public class HomePage
    {
        PageFunctions.PageFunctions pf = new PageFunctions.PageFunctions();
        public HomePage FillInSearchField(string dataToFill)
        {
            pf.FillInField(PageElementIds.HomePageDestinationFieldId, dataToFill);
            return this;
        }
        public HomePage ClickSubmitForm()
        {
            pf.SubmitForm(PageElementIds.HomePageFormId);
            return this;
        }
        public HomePage ClickCheckIn()
        {
            pf.ClickButtonByClass(Scripts.ClickCheckIn, PageElementIds.checkInClassName);
            Thread.Sleep(500); //checking page ready flag will not work for dynamic inner page elements
            return this;
        }
        public HomePage ClickNextPreviousCalendarButton(string button = PageElementIds.calendarNextButton, int timesToPress = 1)
        {

            for (int i = 0; i<= timesToPress; i++)
            {
                pf.ClickButtonByClass(Scripts.ClickCalendarNextPrevious, button);
            }
            
            Thread.Sleep(500); //checking page ready flag will not work for dynamic inner page elements
            return this;
        }
        public HomePage PickDates(string checkInDate = Scripts.ClickCheckInDate, string checkOutDate = Scripts.ClickCheckOutDate)
        {
            pf.ClickButtonByClass(checkInDate, PageElementIds.pickableDate)
                .ClickButtonByClass(checkOutDate, PageElementIds.pickableDate);
            return this;
        }
        public HomePage SelectDates(string checkInDate = null)
        {
            int timesToPress = 1;
            //calculate number of times to click based on checkInDate and month label
            //bui-calendar__month [0] and [1] for check in check out labels
            //case switch for each month?
            ClickCheckIn()
                .ClickNextPreviousCalendarButton(timesToPress: timesToPress)
                .PickDates();
            return this;
        }
        //public HomePage SelectPeopleAndRooms()
        //{
        //    return this;
        //}
        public HomePage SubmitForm(string dataToFill = Destination.Limerick, string checkInDate = null)
        {
            FillInSearchField(dataToFill)
            .SelectDates(checkInDate)
            .ClickSubmitForm();
            return this;
        }
    }
}
