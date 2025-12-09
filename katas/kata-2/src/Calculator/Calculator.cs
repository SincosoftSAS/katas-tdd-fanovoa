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

        public int Multiply(int factor1, int factor2)
        {
            return factor1 *factor2;
        }

        public int Divide(int dividend, int divisor)
        {
            if( divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return dividend / divisor;
        }
    }
}