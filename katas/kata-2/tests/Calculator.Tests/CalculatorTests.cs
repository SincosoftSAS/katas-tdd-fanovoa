using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(8);
        }

        [Fact]
        public void Add_TwoPositiveNumbers6and3_ReturnsSum()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(9);
        }


        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsMultiply()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(40);
        }


        [Fact]
        public void Divide_TwoNumbers_ReturnsDivide()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(2);
        }

        [Fact]
        public void Divide_OneNumberByZero_ExecuteDivisionByZeroException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act
            Action result = () => _calculator.Divide(a, b);

            // Assert
            result.Should().Throw<DivideByZeroException>("Cannot divide by zero");
        }


        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsSumPositive()
        {
            // Arrange
            int a = -10;
            int b = -2;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(12);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = -10;
            int b = -4;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(14);
        }

        [Fact]
        public void Add_WhenOverflowOccurs_ShouldThrowOverflowException()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 1;

            // Act
            Action result = () => _calculator.Add(a, b);

            // Assert
            result.Should().Throw<OverflowException>("Arithmetic operation resulted in an overflow.");
        }


        [Fact]
        public void Subtract_WhenOverflowOccurs_ShouldThrowOverflowException()
        {
            int a = int.MaxValue;
            int b = -1;

            // Act
            Action result = () => _calculator.Subtract(a, b);

            // Assert
            result.Should().Throw<OverflowException>("Arithmetic operation resulted in an overflow.");
        }
        
        [Fact]
        public void Multiply_WhenOverflowOccurs_ShouldThrowOverflowException()
        {
            int a = int.MaxValue;
            int b = 2;

            // Act
            Action result = () => _calculator.Multiply(a, b);

            // Assert
            result.Should().Throw<OverflowException>("Arithmetic operation resulted in an overflow.");
        }
        
        [Fact]
        public void Divide_WhenOverflowOccurs_ShouldThrowOverflowException()
        {
            int a = int.MinValue;
            int b = -1;

            // Act
            Action result = () => _calculator.Divide(a, b);

            // Assert
            result.Should().Throw<OverflowException>("Arithmetic operation resulted in an overflow.");
        }
        
    }
}