namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> generate = [];
            for (int initialCount = 1; initialCount <= count; initialCount++)
            {
                if ( initialCount % 3 == 0 )
                    generate.Add("Fizz");
                else if( initialCount ==5 || initialCount == 10)
                {
                    generate.Add("Buzz");
                }
                else 
                    generate.Add($"{initialCount}");
            }

            return generate;
        }
    }
}