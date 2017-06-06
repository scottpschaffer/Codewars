using System;

namespace DayCount
{
    public class Day
    {

        public string countDays(DateTime d)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(d - today);
            TimeSpan difference = (d - today);
            Console.WriteLine(difference);
            if ( difference.Days < 0)
            {
                return "The day is in the past!";
            }
            else if (difference.Days == 0)
            {
                return "Today is the day!";
            }
            else
            {
                return difference + " days";
            }
        }

        static void Main(string[] args)
        {
            Day day1 = new Day();
            Console.WriteLine(day1.countDays(new DateTime(2017,6,6)));
        }
    }
}
