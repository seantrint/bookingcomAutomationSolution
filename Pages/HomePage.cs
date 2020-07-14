using System;
using System.Collections.Generic;
using System.Text;
namespace bookingComAutomationSolution.Pages
{
    //this should have methods for all the different actions available on the home page (although all we care about in this scenario is searching)
    //it should also have a method to go through a main flow i.e. default search values and click button
    //the main flow method will call the other methods we create but use default test data
    public class HomePage
    {
        PageFunctions.PageFunctions pf = new PageFunctions.PageFunctions();
        public HomePage FillInSearchField(string dataToFill)
        {
            //store this id in model and get it here
            pf.FillInField("ss",dataToFill);
            return this;
        }
        public HomePage ClickSubmitForm()
        {
            //button on home page does not have id
            //need to access id of the form and use submit()
            //store this id in model and get it here
            pf.SubmitForm("frm");
            return this;
        }
        public HomePage SelectDates()
        {
            return this;
        }
        public HomePage SelectPeopleAndRooms()
        {
            return this;
        }
        public HomePage SubmitForm(string dataToFill = "Limerick, Limerick County, Ireland")
        {
            FillInSearchField(dataToFill)
            .ClickSubmitForm();
            return this;
        }
    }
}
