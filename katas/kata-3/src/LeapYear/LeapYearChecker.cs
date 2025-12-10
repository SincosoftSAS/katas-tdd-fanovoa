namespace LeapYear
{
    public static class LeapYearChecker
    {
        private const string? YearMustBeGreaterThan = "Year must be greater than 0";

        public static bool IsLeapYear(int year)
        {
            ExecuteExceptionWhenYearLessThanZero(year);
            return IsDivisibleBy(year,400) || IsDivisibleByFourAndNotBy100(year);
        }

        private static void ExecuteExceptionWhenYearLessThanZero(int year)
        {
            if( year <=0) throw new ArgumentException(YearMustBeGreaterThan);
        }

        private static bool IsDivisibleByFourAndNotBy100(int year)
        {
            return IsDivisibleBy(year,4) && !IsDivisibleBy(year,100);
        }
        
        private static bool IsDivisibleBy(int year, int divisor) => (year % divisor == 0);
    }
}
