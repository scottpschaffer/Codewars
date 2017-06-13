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
            Assert.Equal("The day is in the past!", TwoDaysAgo.countDays(DateTime.Now - (new TimeSpan(48, 0, 0))));
        }

        [Fact]
        public void Test2_1DayAgo()
        {
            Day OneDayAgo = new Day();
            Assert.Equal("The day is in the past!", OneDayAgo.countDays(DateTime.Now - (new TimeSpan(24, 0, 0))));
        }

        [Fact]
        public void Test3_SameDay()
        {
            Day Today = new Day();
            Assert.Equal("Today is the day!", Today.countDays(DateTime.Now));
        }

        [Fact]
        public void Test4_1DayAhead()
        {
            Day Tomorrow = new Day();
            Assert.Equal("1 days", Tomorrow.countDays(DateTime.Now + (new TimeSpan(24, 0, 0))));
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
