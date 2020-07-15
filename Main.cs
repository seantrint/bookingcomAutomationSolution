using NUnit.Framework;
using bookingComAutomationSolution.Pages;
using bookingComAutomationSolution.TestData;

namespace bookingComAutomationSolution
{
    //this file should just have tests
    //it should call test methods from other classes - this makes the solution maintainable 
    //i.e. 10 tests use 1 test method, updating 1 test method fixes 10 test failures
    public class Main
    {
        Driver chromedriver = new Driver();
        HomePage hp = new HomePage();
        SearchResultsPage srp = new SearchResultsPage();
        [Test]
        public void TC_000001_CheckStarRatingLabels()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Fuerteventura);
            srp
                .CheckFilters(
                new[]
                    {
                        PageElementIds.OneStarXPathLabel,
                        PageElementIds.TwoStarXPathLabel,
                        PageElementIds.ThreeStarXPathLabel,
                        PageElementIds.FourStarXPathLabel,
                        PageElementIds.FiveStarXPathLabel
                    },
                new[]
                    {
                        Filters.OneStarLabel,
                        Filters.TwoStarLabel,
                        Filters.ThreeStarLabel,
                        Filters.FourStarLabel,
                        Filters.FiveStarLabel,
                        Filters.UnratedLabel
                    }
                );
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000002_CheckStarRatingFunctionality()
        {

        }

    }
}
