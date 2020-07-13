using NUnit.Framework;

namespace bookingComAutomationSolution
{
    //this file should just have tests
    //it should call test methods from other classes - this makes the solution maintainable 
    //i.e. 10 tests use 1 test method, updating 1 test method fixes 10 test failures
    public class Main
    {
        Driver chromedriver = new Driver();

        [Test]
        public void checkLabels()
        {
            chromedriver.startApplication().MaximizeWindow();

            chromedriver.closeBrowser();

            //Driver.Driver.startBrowser();
            //driver.Close();
        }

    }
}
