namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (IsDivisibleByFour(year) && year % 100 != 0)
            {
                return true;
            }
            

            return false ;
        }

        private static bool IsDivisibleByFour(int year)
        {
            return year % 4 == 0;
        }
    }
}
