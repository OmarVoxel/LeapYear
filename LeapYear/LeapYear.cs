using System;

namespace LeapYear
{
    public class LeapYear
    {
        public static bool Calculate(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 400 == 0 && year % 100 != 0)
                return false;
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            if(year % 4 != 0)
                return false;
            return false;
        }
    }
}