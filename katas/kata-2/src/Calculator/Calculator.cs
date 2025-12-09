namespace Calculator
{
    public class Calculator
    {
        public static int Add(int addend1, int addend2)
        {
            if (addend1 < 0 && addend2 < 0)
                return Multiply(addend1+addend2, -1);
            return addend1 + addend2;
        }

        public static int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public static int Multiply(int factor1, int factor2)
        {
            return factor1 *factor2;
        }

        public static int Divide(int dividend, int divisor)
        {
            ExecuteExeptionDivisorZero(divisor);
            return dividend / divisor;
        }

        private static void ExecuteExeptionDivisorZero(int divisor)
        {
            if( divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero");
        }
    }
}