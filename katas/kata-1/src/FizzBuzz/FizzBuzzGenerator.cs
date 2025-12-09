namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> _generate = [];

            for (int initialCount = 1; initialCount <= count; initialCount++)
            {
                if (IsDivisibleForFifteen(initialCount))
                    _generate.Add("FizzBuzz");
                else if (IsDivisibleForThree(initialCount))
                    _generate.Add("Fizz");
                else if (IsDivisibleForFive(initialCount))
                    _generate.Add("Buzz");
                else
                    _generate.Add($"{initialCount}");
            }

            return _generate;
        }

        private static bool IsDivisibleForFifteen(int initialCount) => initialCount % 15 == 0;

        private static bool IsDivisibleForFive(int initialCount) => initialCount % 5 == 0;

        private static bool IsDivisibleForThree(int initialCount) => initialCount % 3 == 0;
    }
}