using System;
using System.Collections.Generic;

namespace WeekdayFinderApp.Objects
{
    public class WeekdayFinder
    {
        private static string _referenceDay;
        private static string _referenceDate;

        public WeekdayFinder()
        {
            _referenceDay = "Thursday";
            _referenceDate = "02/16/2017";
        }

        public string GetReferenceDay()
        {
            return _referenceDay;
        }
        public string GetReferenceDate()
        {
            return _referenceDate;
        }
        public string GetDayAfterReferenceDate()
        {
            return "blah";
        }
    }
}
