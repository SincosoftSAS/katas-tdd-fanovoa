using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }
        
        [Fact]
        public void Generate_WithTwo_ReturnsListWithTwo()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(2);
            
            // Assert
            result.Should().HaveCount(2);
            result[1].Should().Be("2");
        }
        
        [Fact]
        public void Generate_WithThree_ReturnsListWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);
            
            // Assert
            result.Should().HaveCount(3);
            result[2].Should().Be("Fizz");
        }
        
        [Fact]
        public void Generate_WithSix_ReturnsListWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(6);
            
            // Assert
            result.Should().HaveCount(6);
            result[5].Should().Be("Fizz");
        }
        
        [Fact]
        public void Generate_WithNine_ReturnsListWithFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(9);
            
            // Assert
            result.Should().HaveCount(9);
            result[8].Should().Be("Fizz");
        }
        
        [Fact]
        public void Generate_WithFive_ReturnsListWithBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);
            
            // Assert
            result.Should().HaveCount(5);
            result[4].Should().Be("Buzz");
        }
        
        [Fact]
        public void Generate_WithTen_ReturnsListWithBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(10);
            
            // Assert
            result.Should().HaveCount(10);
            result[9].Should().Be("Buzz");
        }
        
        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }
    }
}