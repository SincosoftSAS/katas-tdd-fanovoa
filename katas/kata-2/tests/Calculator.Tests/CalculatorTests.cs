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
            int result = _calculator.Add(a, b);

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
            int result = _calculator.Add(a, b);

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
            int result = _calculator.Subtract(a, b);
        
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
            int result = _calculator.Multiply(a, b);
        
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
            int result = _calculator.Divide(a, b);
        
            // Assert
            result.Should().Be(2);
        }
        
        [Fact]
        public void Divide_OneNumberByZero_ExecuteDivisionByZeroException()
        {
            // Arrange
            int a = 10;
            int b = 5;
        
            // Act
            Action result = () => _calculator.Divide(a, b);
        
            // Assert
            result.Should().Throw<DivideByZeroException>("Cannot divide by zero");
        }

        
    }
}