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
        public void FindWeekDay_ReturnReferenceDay_String()
        {
            //arrange
            string referenceDay = "Sunday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            // act
            string result = newWeekdayFinder.FindWeekDay(01, 01, 17);
            // assert
            Assert.Equal(result, referenceDay);
        }

        // Test to see what day the day after referenceDay will be
        [Fact]
        public void FindWeekDay_ReturnDayAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Monday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.FindWeekDay(01, 02, 17);
            //assert
            Assert.Equal(result, referenceDay);
        }

        // Test to see what day it is in one week from referenceDay
        [Fact]
        public void FindWeekDay_ReturnDayOneWeekAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Sunday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.FindWeekDay(01, 08, 17);
            //assert
            Assert.Equal(result, referenceDay);
        }
        // Test to see what day it is in one month from referenceDay
        [Fact]
        public void FindWeekDay_ReturnDayOneMonthAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Wednesday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.FindWeekDay(02, 01, 17);
            //assert
            Assert.Equal(referenceDay, result);
        }

        [Fact]
        public void FindWeekDay_ReturnDayOneYearAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Monday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.FindWeekDay(01, 01, 18);
            //assert
            Assert.Equal(referenceDay, result);
        }

        [Fact]
        public void FindWeekDay_ReturnDaySixMonthsAfterReferenceDate_String()
        {
            //arrange
            string referenceDay = "Saturday";
            WeekdayFinder newWeekdayFinder = new WeekdayFinder();
            //act
            string result = newWeekdayFinder.FindWeekDay(07, 01, 17);
            //assert
            Assert.Equal(referenceDay, result);
        }
    }
}
