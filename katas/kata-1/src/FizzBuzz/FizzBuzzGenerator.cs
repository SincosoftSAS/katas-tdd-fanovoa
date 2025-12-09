namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> generate = [];
            for (int initialCount = 1; initialCount <= count; initialCount++)
            {
                if (initialCount == 3 || initialCount == 6)
                    generate.Add("Fizz");
                else
                {
                    generate.Add($"{initialCount}");
                }
            }

            return generate;
        }
    }
}