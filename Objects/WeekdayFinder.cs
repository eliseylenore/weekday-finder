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

        public string GetDayAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> tomorrow = new Dictionary<string, int>()
            {
                { "month", 01 },
                { "day", 02 },
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
                { "month", 01 },
                { "day", 08 },
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
                { "month", 02 },
                { "day", 01 },
                { "year", 17 }
            };

            //find difference between set date and reference date
            int monthDifference = oneMonth["month"] - _referenceDate["month"];
            int dayDifference = oneMonth["day"] + (31-_referenceDate["day"]);

            //return that day
            return _daysOfTheWeek[(_referenceDay + dayDifference) % 7];

        }

        public string GetDayOneYearAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> oneMonth = new Dictionary<string, int>()
            {
                { "month", 01 },
                { "day", 01 },
                { "year", 18 }
            };

            //find difference between set date and reference date
            int yearDifference = oneMonth["year"] - _referenceDate["year"];
            int monthDifference = oneMonth["month"] - _referenceDate["month"];
            int dayDifference = oneMonth["day"] -_referenceDate["day"];

            //return that day
            return _daysOfTheWeek[(_referenceDay + yearDifference) % 7];
        }

        public string GetDaySixMonthsAfterReferenceDate()
        {
            //determine the difference between days
            Dictionary<string, int> sixMonths = new Dictionary<string, int>()
            {
                { "month", 07 },
                { "day", 01 },
                { "year", 17 }
            };

            //find difference between set date and reference date
            int monthDifference = sixMonths["month"] - _referenceDate["month"];
            int dayDifference = sixMonths["day"] + (_daysInAMonth[_referenceDate["month"]] - _referenceDate["day"]);
            for (int i = 2; i <= monthDifference ; i++)
            {
                dayDifference +=_daysInAMonth[i];
            }

            //return that day
            return _daysOfTheWeek[(_referenceDay + dayDifference) % 7];
        }
    }
}
