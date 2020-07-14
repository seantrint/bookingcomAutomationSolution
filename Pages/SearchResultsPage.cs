using bookingComAutomationSolution.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.Pages
{
    public class SearchResultsPage
    {
        PageFunctions.PageFunctions pf = new PageFunctions.PageFunctions();
        public SearchResultsPage CheckFilter(string xpath = PageElementIds.StarRatingLabelXPath, string filter = Filters.StarRatingLabel)
        {
            pf.AssertText(xpath, filter);
           
            return this;
        }
        public SearchResultsPage CheckFilters(string[] xpaths, string[] filters)
        {
            for(int i = 0; i<= xpaths.Length-1; i++)
            {
                pf.AssertText(xpaths[i], filters[i]);
            }
           
            return this;
        }
        public SearchResultsPage CheckStarRatingSection()
        {
            CheckFilters
                (
                new[]
                    {
                        PageElementIds.OneStarXPath,
                        PageElementIds.TwoStarXPath,
                        PageElementIds.ThreeStarXPath,
                        PageElementIds.FourStarXPath,
                        PageElementIds.FiveStarXPath
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

            return this;
        }
    }
}
