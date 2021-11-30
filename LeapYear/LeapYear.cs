namespace LeapYear
{
    public class LeapYear
    {
        public static bool Calculate(int year)
            => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}