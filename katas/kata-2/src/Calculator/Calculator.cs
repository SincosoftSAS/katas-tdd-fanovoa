namespace Calculator
{
    public class Calculator
    {
        public static int Add(int addend1, int addend2)
        {
            try
            {
                checked
                {
                    var add = addend1 + addend2;
                    return TheNumbersAreNegatives(addend1, addend2) ? Multiply(add, -1) : add;
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("Arithmetic operation resulted in an overflow.");
            }
        }


        public static int Subtract(int minuend, int subtrahend)
        {
            try
            {
                checked
                {
                    if (TheNumbersAreNegatives(minuend, subtrahend))
                        return Add(minuend, subtrahend);

                    return minuend - subtrahend;
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("Arithmetic operation resulted in an overflow.");
            }
        }

        public static int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        public static int Divide(int dividend, int divisor)
        {
            ExecuteExceptionDivisorZero(divisor);
            return dividend / divisor;
        }

        private static void ExecuteExceptionDivisorZero(int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot divide by zero");
        }

        private static bool TheNumbersAreNegatives(int addend1, int addend2) => addend1 < 0 && addend2 < 0;
    }
}