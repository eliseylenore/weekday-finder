using System;
using System.Collections.Generic;

namespace WeekdayFinderApp.Objects
{
    public class WeekdayFinder
    {
        private static Dictionary<string, int> _referenceDate = new Dictionary<string, int>()
        {
            { "month", 02 },
            { "day", 16 },
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

        private static int _referenceDay = 4;

        public string GetReferenceDay()
        {
            return _daysOfTheWeek[4];
        }

        public string GetReferenceDate()
        {
            return _referenceDate["month"] + "/" + _referenceDate["day"] + "/" + _referenceDate["year"];
        }

        public string GetDayAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> tomorrow = new Dictionary<string, int>()
            {
                { "month", 02 },
                { "day", 17 },
                { "year", 17 }
            };

            //find what day comes after Thursday
            int difference = tomorrow["day"] - _referenceDate["day"];

            //return that day
            return _daysOfTheWeek[_referenceDay + difference];
        }

        public string GetDayOneWeekAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> oneWeek = new Dictionary<string, int>()
            {
                { "month", 02 },
                { "day", 23 },
                { "year", 17 }
            };

            //find difference between set date and reference date
            int difference = oneWeek["day"] - _referenceDate["day"];

            //return that day
            return _daysOfTheWeek[(_referenceDay + difference) % 7];

        }
        public string GetDayOneMonthAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> oneMonth = new Dictionary<string, int>()
            {
                { "month", 03 },
                { "day", 16 },
                { "year", 17 }
            };

            //find difference between set date and reference date
            int monthDifference = oneMonth["month"] - _referenceDate["month"];
            int dayDifference = oneMonth["day"] + (28-_referenceDate["day"]);

            //return that day
            return _daysOfTheWeek[(_referenceDay + dayDifference) % 7];

        }
    }
}
