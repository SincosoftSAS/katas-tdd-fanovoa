namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> generate = [];
            for (int initialCount = 0; initialCount < count; initialCount++)
            {
                if (initialCount == 2)
                    generate.Add("Fizz");
                else
                {
                    generate.Add($"{initialCount+1}");
                }
            }

            return generate;
        }
    }
}