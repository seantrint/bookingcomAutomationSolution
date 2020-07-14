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
            pf.AssertText(xpath, result);
            return this;
        }
        public SearchResultsPage CheckFilter(string xpath, string filter)
        {
            pf.AssertText(xpath, filter);
            return this;
        }
        public SearchResultsPage ClickFilter(string script, int sectionId, int checkBoxId)
        {
            pf.ClickCheckbox(script, sectionId, checkBoxId);
            Thread.Sleep(2000);
            return this;
        }
        public SearchResultsPage UnClickFilter()
        {
            pf.CustomScript(Scripts.ClickFirstChildButton, PageElementIds.SelectedCheckBox);
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
