namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if ( IsDivisibleByFour(year) && IsNotDivisibleByHundred(year) || IsDivisibleByFourHundred(year) )
                return true;
            

            return false ;
        }

        private static bool IsDivisibleByFourHundred(int year)
        {
            return year % 400 == 0;
        }

        private static bool IsNotDivisibleByHundred(int year)
        {
            return year % 100 != 0;
        }

        private static bool IsDivisibleByFour(int year)
        {
            return year % 4 == 0;
        }
    }
}
