using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static bool Calculate(int year)
        {
            return year % 400 == 0;
        }
    }
}