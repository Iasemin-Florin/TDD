using System;
using Xunit;
using Calculator;

namespace Calculator.tests
{
    public class CalcTest
    {
        [Fact]
        public void AdditionSimpleValueShouldCalculate()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual = SimpCalc.Addition(3, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractionSimpleValueShouldCalculate()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual = SimpCalc.Subtraction(10, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplicationSimpleValueShouldCalculate()
        {
            // Arrange
            double expected = 25;

            // Act
            double actual = SimpCalc.Multiplication(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivisionSimpleValueShouldCalculate()
        {
            // Arrange
            double expected = 7;

            // Act
            double actual = SimpCalc.Division(49, 7);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
