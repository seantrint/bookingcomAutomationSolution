using NUnit.Framework;
using bookingComAutomationSolution.Pages;

namespace bookingComAutomationSolution
{
    //this file should just have tests
    //it should call test methods from other classes - this makes the solution maintainable 
    //i.e. 10 tests use 1 test method, updating 1 test method fixes 10 test failures
    public class Main
    {
        Driver chromedriver = new Driver();
        HomePage hp = new HomePage();
        [Test]
        public void checkLabels()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow()
                .FillInField("ss", "Limerick, Limerick County, Ireland")
                .ClickSubmitButton("frm")
                .closeBrowser();
            //Driver.Driver.startBrowser();
            //driver.Close();
        }

    }
}
