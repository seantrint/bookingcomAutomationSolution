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
        //need to split into very small tests to avoid performance issues and intermittent fails
        [Test]
        public void TC_000001_CheckStarRatingLabels()
        {
            //check labels for star rating
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Fuerteventura);
            srp
                .CheckFilters(
                new[]
                    {
                        PageElementIds.FirstStarXPathLabel,
                        PageElementIds.SecondStarXPathLabel,
                        PageElementIds.ThirdStarXPathLabel,
                        PageElementIds.FourthStarXPathLabel,
                        PageElementIds.FifthStarXPathLabel
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
        public void TC_000002_CheckOneStarRating()
        {
            //click different star options and validate result at top of grid
            //can only do partial match as result can be either hotel or apartment
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Fuerteventura);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.FirstStarCheckboxId)
                .CheckFilterContains(PageElementIds.HotelStarRatingXPath, SearchGrid.OneStar, ignoreChars: new[] { "-" });
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000003_CheckTwoStarRating()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Fuerteventura);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.SecondStarCheckboxId)
                .CheckFilterContains(PageElementIds.HotelStarRatingXPath, SearchGrid.TwoStar, ignoreChars: new[] { "-" });
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000004_CheckThreeStarRating()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Limerick);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.FirstStarCheckboxId)
                .CheckFilterContains(PageElementIds.HotelStarRatingXPath, SearchGrid.ThreeStar, ignoreChars: new[] { "-" });
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000005_CheckFourStarRating()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Fuerteventura);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.FourthStarCheckboxId)
                .CheckFilterContains(PageElementIds.HotelStarRatingXPath, SearchGrid.FourStar, ignoreChars: new[] { "-" });
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000006_CheckFiveStarRatingAndCheckSpa()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Limerick);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.ThirdStarCheckboxId)
                .CheckFilter(PageElementIds.SpaLabelXPath, Filters.SpaLabel)
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.FunThingsSectionId, PageElementIds.SpaCheckboxId)
                .CheckFilterContains(PageElementIds.HotelStarRatingXPath, SearchGrid.FiveStar, ignoreChars: new[] { "-" });
            chromedriver
                .closeBrowser();
        }
        [Test]
        public void TC_000007_CheckUnratedStarRating()
        {
            chromedriver
                .startApplication()
                .MaximizeWindow();
            hp
                .SubmitForm(Destination.Limerick);
            srp
                .ClickFilter(Scripts.ClickFilterCheckbox, PageElementIds.StarRatingSectionId, PageElementIds.FourthStarCheckboxId)
                .CheckUnratedResults();
            chromedriver
                .closeBrowser();
        }
    }
}
