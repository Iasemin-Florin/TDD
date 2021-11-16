using System;

namespace Calculator
{
    public static class SimpCalc
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            else
            {
                return num1 / num2;
            }
        }
    }
}
