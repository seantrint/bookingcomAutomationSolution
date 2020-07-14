using System;
using System.Collections.Generic;
using System.Text;

namespace bookingComAutomationSolution.TestData
{
    //here is for test data
    //for now hardcode data in this class
    //ideally this should reference keys in a database like sqlite
    public static class Filters
    {
        public const string StarRatingLabel = "Star Rating";
        public const string OneStarLabel = "1 star";
        public const string TwoStarLabel = "2 stars";
        public const string ThreeStarLabel = "3 stars";
        public const string FourStarLabel = "4 stars";
        public const string FiveStarLabel = "5 stars";
        public const string UnratedLabel = "Unrated";
    }
}
