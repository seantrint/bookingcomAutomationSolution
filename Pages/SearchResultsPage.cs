using bookingComAutomationSolution.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace bookingComAutomationSolution.Pages
{
    public class SearchResultsPage
    {
        PageFunctions.PageFunctions pf = new PageFunctions.PageFunctions();
        public SearchResultsPage ClickLowestPriceFirst()
        {
            pf.CustomScript(Scripts.ClickFirstChildButton, PageElementIds.LowestPriceFirstButton);
            return this;
        }
        public SearchResultsPage CheckUnratedResults()
        {
            //there is no stars in first result
            pf.ElementDoesNotExist(PageElementIds.HotelStarRatingXPath);
            return this;
        }
        public SearchResultsPage CheckFirstSearchGridResult(string xpath, string result)
        
        {
            Thread.Sleep(2000);
            pf.AssertText(xpath, result);
            Thread.Sleep(2000);
            return this;
        }
        public SearchResultsPage ClickFirstSearchResult()
        {
            pf.CustomScript(Scripts.ClickFirstClassName, PageElementIds.FirstSearchResultLink);

            Thread.Sleep(1000); 
            return this;
        }
        public SearchResultsPage CheckFilter(string xpath, string filter, bool shouldBe = true, string filter2 = null)
        {
            //check for x stars or x-star hotel, if see either one then pass test
            //reason for this is that website recommends properties which can change and be either apartment or hotel
            //checking hotel name does nothing for validating star rating system so need to check star label
            pf.AssertText(xpath, filter, shouldBe, filter2);
          
            
            return this;
        }
        public SearchResultsPage ClickFilter(string script, int sectionId, int checkBoxId)
        {
            Thread.Sleep(3500);
            pf.WaitForCheckbox(script, sectionId, checkBoxId)
                .ClickCheckbox(script, sectionId, checkBoxId);
            Thread.Sleep(2500);
            return this;
        }
        public SearchResultsPage UnClickFilter()
        {
            Thread.Sleep(3500);
            pf.CustomScript(Scripts.ClickFirstChildButton, PageElementIds.SelectedCheckBox);
            Thread.Sleep(2500);
            return this;
        }
        public SearchResultsPage CheckFilters(string[] xpaths, string[] filters)
        {
            for(int i = 0; i<= xpaths.Length-1; i++)
            {
                CheckFilter(xpaths[i], filters[i]);
            }
           
            return this;
        }
    }
}
