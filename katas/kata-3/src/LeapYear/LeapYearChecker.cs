namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if( year ==0) throw new ArgumentException("Year must be greater than 0");
            if( year <0) throw new ArgumentException("Year must be greater than 0");
            return IsDivisibleBy(year,400) || IsDivisibleByFourAndNotBy100(year);
        }

        private static bool IsDivisibleByFourAndNotBy100(int year)
        {
            return IsDivisibleBy(year,4) && !IsDivisibleBy(year,100);
        }


        private static bool IsDivisibleBy(int year, int divisor) => (year % divisor == 0);
    }
}
