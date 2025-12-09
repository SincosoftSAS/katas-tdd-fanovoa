namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> generate = ["1"];
            if (!generate.Exists(number => number == count.ToString()))
            {
                generate.Add(count.ToString());
            }
            
            return generate;
        }
    }
}