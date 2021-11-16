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
            throw new NotImplementedException();
        }

        [Fact]
        public void MultiplicationSimpleValueShouldCalculate()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void DivisionSimpleValueShouldCalculate()
        {
            throw new NotImplementedException();
        }
    }
}
