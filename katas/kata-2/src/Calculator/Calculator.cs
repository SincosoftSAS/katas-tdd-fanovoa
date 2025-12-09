namespace Calculator
{
    public class Calculator
    {
        public int Add(int addend1, int addend2)
        {
            return addend1 + addend2;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int a, int b)
        {
            return a *b;
        }

        public int Divide(int a, int b)
        {
            // TODO: Implement using TDD: Red → Green → Refactor
            // Hint: ¿Qué pasa si b es 0?
            throw new NotImplementedException("Implement using TDD: Red → Green → Refactor");
        }
    }
}