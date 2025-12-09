namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> _generate = [];

            for (int number = 1; number <= count; number++)
            {
                if (IsDivisibleFor(number,15))
                    _generate.Add("FizzBuzz");
                else if (IsDivisibleFor(number,3))
                    _generate.Add("Fizz");
                else if (IsDivisibleFor(number,5))
                    _generate.Add("Buzz");
                else
                    _generate.Add($"{number}");
            }

            return _generate;
        }
        private static bool IsDivisibleFor( int multiple, int divisor) => multiple % divisor == 0;
    }
}