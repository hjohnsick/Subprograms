using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subprograms
{
    public class Calculator
    {
        public static double SumOfThree(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public static double AverageOfFourNumbers(double num1, double num2, double num3, double num4)
        {
            double sum = num1 + num2 + num3 + num4;

            return sum / 4;
        }

        public static double FindMaxNum(double num1, double num2, double num3)
        {
        
            List<double> numbers = new List<double>
            {
                num1, num2, num3
            };

            return numbers.Max();
        }

        public static double FindMinNum(double num1, double num2, double num3)
        {
            List<double> numbers = new List<double>
            {
                num1, num2, num3
            };

            return numbers.Min();
        }
    }
}
