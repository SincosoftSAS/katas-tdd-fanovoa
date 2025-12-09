namespace Calculator
{
    public class Calculator
    {
        private const string? CannotDivideByZero = "Cannot divide by zero";
        private const string? ArithmeticOperationResultedInAnOverflow = "Arithmetic operation resulted in an overflow.";

        public int Add(int addend1, int addend2)
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
                throw  HandleOverflowException();
            }
        }

        public int Subtract(int minuend, int subtrahend)
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
                throw new OverflowException(ArithmeticOperationResultedInAnOverflow);
            }
        }

        public int Multiply(int factor1, int factor2)
        {
            try
            {
                checked
                {
                    return factor1 * factor2;
                }

            }
            catch (OverflowException)
            {
                throw HandleOverflowException();
            }
        }

        public int Divide(int dividend, int divisor)
        {
            ExecuteExceptionDivisorZero(divisor);

            try
            {
                checked
                {
                    return dividend / divisor;
                    
                }
            }
            catch (OverflowException)
            {
                throw HandleOverflowException();

            }
        }

        private static void ExecuteExceptionDivisorZero(int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException(CannotDivideByZero);
        }

        private static bool TheNumbersAreNegatives(int addend1, int addend2) => addend1 < 0 && addend2 < 0;
        
        private static Exception HandleOverflowException() => new OverflowException(ArithmeticOperationResultedInAnOverflow);
        
    }
}