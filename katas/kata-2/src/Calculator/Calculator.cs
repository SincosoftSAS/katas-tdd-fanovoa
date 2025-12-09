namespace Calculator
{
    public class Calculator
    {
        public static int Add(int addend1, int addend2)
        {
            var add = addend1 + addend2;
            return TheAddendsAreNegatives(addend1, addend2) ? Multiply(add, -1) : add;
        }


        public static int Subtract(int minuend, int subtrahend)
        {
            if (minuend < 0 && subtrahend < 0)
                return Add(minuend * -1, subtrahend * -1);
            return minuend - subtrahend;
        }

        public static int Multiply(int factor1, int factor2)
        {
            return factor1 *factor2;
        }

        public static int Divide(int dividend, int divisor)
        {
            ExecuteExceptionDivisorZero(divisor);
            return dividend / divisor;
        }

        private static void ExecuteExceptionDivisorZero(int divisor)
        {
            if( divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero");
        }
        
        private static bool TheAddendsAreNegatives(int addend1, int addend2) => addend1 < 0 && addend2 < 0;
        
    }
}