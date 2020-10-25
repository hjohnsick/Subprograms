using System;
using Xunit;
using Subprograms;

namespace Calculations.Tests
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(11.25, 50.75, 20)]
        public void SumofThree_ShouldReturnSumOfThreeNumbers(double num1, double num2, double num3)
        {
            var expected = 82;

            var actual = Calculator.SumOfThree(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 11.3, 2.1, 66.777)]
        public void AverageOfFourNumbers_ShouldReturnAverage(double num1, double num2, double num3, double num4)
        {
            var expected = 23.79425;

            var actual = Calculator.AverageOfFourNumbers(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 11.5, 2)]
        public void FindMaxNum_ShouldReturnLargestNumber(double num1, double num2, double num3)
        {
            var expected = 11.5;

            var actual = Calculator.FindMaxNum(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 55, 0, 0)]
        [InlineData(2.2, 88, 2.5, 2.2)]
        public void FindMinNum_ShouldReturnSmallestNumber(double num1, double num2, double num3, double expected)
        {

            var actual = Calculator.FindMinNum(num1, num2, num3);

            Assert.Equal(expected, actual);
            
        }
        
    }
}
