using System;
using Xunit;

namespace DayCount.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_2DaysAgo()
        {
            Day TwoDaysAgo = new Day();
            Assert.Equal("The day is in the past!", TwoDaysAgo.countDays(new DateTime(2017,6,3)));
        }

        [Fact]
        public void Test2_1DayAgo()
        {

        }

        [Fact]
        public void Test3_SameDay()
        {

        }

        [Fact]
        public void Test4_1DayAhead()
        {

        }

        [Fact]
        public void Test5_14MonthsAhead()
        {

        }

        [Fact]
        public void Test6_14MonthsBehind()
        {

        }
    }
}
