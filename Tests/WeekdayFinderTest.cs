using Xunit;
using WeekdayFinderApp.Objects;
using System;
using System.Collections.Generic;

namespace WeekdayFinderApp
{
    public class WeekdayFinderTest
    {
        // Test to see if reference day is set.
        [Fact]
        public void GetReferenceDay_ReturnReferenceDay_String()
        {
            //arrange
            string referenceDay = "Thursday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            // act
            string result = newWeekdayFinder.GetReferenceDay();
            // assert
            Assert.Equal(result, referenceDay);
        }

        // Test to see what day the day after referenceDay will be
        [Fact]
        public void GetDayAfterReferenceDate_ReturnDayAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Friday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDayAfterReferenceDate();
            //assert
            Assert.Equal(result, referenceDay);
        }
    }
}
