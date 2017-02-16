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
            string referenceDay = "Sunday";
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
            string referenceDay = "Monday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDayAfterReferenceDate();
            //assert
            Assert.Equal(result, referenceDay);
        }

        // Test to see what day it is in one week from referenceDay
        [Fact]
        public void GetDayOneWeekAfterReferenceDate_ReturnDayOneWeekAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Sunday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDayOneWeekAfterReferenceDate();
            //assert
            Assert.Equal(result, referenceDay);
        }
        // Test to see what day it is in one month from referenceDay
        [Fact]
        public void GetDayOneMonthAfterReferenceDate_ReturnDayOneMonthAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Wednesday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDayOneMonthAfterReferenceDate();
            //assert
            Assert.Equal(referenceDay, result);
        }

        [Fact]
        public void GetDayOneYearAfterReferenceDate_ReturnDayOneYearAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Monday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDayOneYearAfterReferenceDate();
            //assert
            Assert.Equal(referenceDay, result);
        }

        [Fact]
        public void GetDaySixMonthsAfterReferenceDate_ReturnDaySixMonthsAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Saturday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.GetDaySixMonthsAfterReferenceDate();
            //assert
            Assert.Equal(referenceDay, result);
        }
    }
}
