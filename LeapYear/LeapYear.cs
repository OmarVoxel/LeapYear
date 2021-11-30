using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static bool Calculate(int year)
        {
            bool yearIsDivisibleBy4 = year % 4 == 0;
            bool yearIsDivisibleBy100 = year % 100 == 0;
            bool yearIsDivisibleBy400 = year % 400 == 0;

            return (yearIsDivisibleBy4 && (!yearIsDivisibleBy100 || yearIsDivisibleBy400));
        }
    }
}