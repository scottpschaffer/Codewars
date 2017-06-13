using System;

namespace DayCount
{
    public class Day
    {

        public string countDays(DateTime d)
        {
            d += new TimeSpan(23, 59, 0);
            DateTime today = DateTime.Now;
            TimeSpan difference = (d - today);

            if ((difference.Days <= 0) && ((difference.Hours < 0) || (difference.Minutes < 0) || (difference.Seconds < 0) || (difference.Milliseconds < 0)))
            {
                return "The day is in the past!";
            }
            else if (difference.Days == 0)
            {
                return "Today is the day!";
            }
            else
            {
                return difference.Days + " days";
            }
        }

        static void Main(string[] args)
        {
            Day day1 = new Day();
            Console.WriteLine(day1.countDays(new DateTime(2017,6,13)));
        }
    }
}
