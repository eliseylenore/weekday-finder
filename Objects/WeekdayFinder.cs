using System;
using System.Collections.Generic;

namespace WeekdayFinderApp.Objects
{
    public class WeekdayFinder
    {
        private static Dictionary<string, int> _referenceDate = new Dictionary<string, int>()
        {
            { "month", 01 },
            { "day", 01 },
            { "year", 17 }
        };

        private static Dictionary<int, string> _daysOfTheWeek = new Dictionary<int, string>()
        {
            { 0, "Sunday" },
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" }
        };

        private static Dictionary<int, int> _daysInAMonth = new Dictionary<int, int>()
        {
            { 01, 31 },
            { 02, 28 },
            { 03, 31 },
            { 04, 30 },
            { 05, 31 },
            { 06, 30 },
            { 07, 31 },
            { 08, 31 },
            { 09, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
        };

        private static int _referenceDay = 0;

        public string GetReferenceDay()
        {
            return _daysOfTheWeek[0];
        }

        public string GetReferenceDate()
        {
            return _referenceDate["month"] + "/" + _referenceDate["day"] + "/" + _referenceDate["year"];
        }


        public string FindWeekDay(int month, int day, int year)
        {
            //determine the difference between days
            Dictionary<string, int> newDictionary = new Dictionary<string, int>()
            {
                { "month", month },
                { "day", day },
                { "year", year }
            };

            //find difference between set date and reference date
            int yearDifference = newDictionary["year"] - _referenceDate["year"];
            int monthDifference = newDictionary["month"] - _referenceDate["month"];
            int dayDifference = 0;
            if(monthDifference != 0)
            {
                dayDifference = newDictionary["day"] + (_daysInAMonth[_referenceDate["month"]] - _referenceDate["day"]);
                for (int i = 2; i <= monthDifference ; i++)
                {
                    dayDifference +=_daysInAMonth[i];
                }
            }
            else
            {
                dayDifference = newDictionary["day"] - _referenceDate["day"];

            }
            //return that day
            return _daysOfTheWeek[(_referenceDay + dayDifference + yearDifference) % 7];
        }
    }
}
