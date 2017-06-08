using System;

namespace DayCount
{
    public class Day
    {

        public string countDays(DateTime d)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("One" + (d - today));
            TimeSpan difference = (d - today);
            TimeSpan newDifference;
            Console.WriteLine("Difference" + difference);
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
                if ((difference.Hours > 0) || (difference.Minutes > 0) || (difference.Seconds > 0) || (difference.Milliseconds > 0))
                {
                    newDifference = difference + new TimeSpan(24, 0, 0);
                }
                return newDifference.Days + " days";
            }
        }

        static void Main(string[] args)
        {
            Day day1 = new Day();
            Console.WriteLine(day1.countDays(new DateTime(2017,6,17)));
        }
    }
}
