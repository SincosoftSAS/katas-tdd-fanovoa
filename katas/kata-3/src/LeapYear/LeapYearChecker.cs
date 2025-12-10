namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (IsNotDivisibleByFour(year))
            {
                return false;
            }

            return true;
        }

        private static bool IsNotDivisibleByFour(int year)
        {
            return year % 4 != 0;
        }
    }
}
