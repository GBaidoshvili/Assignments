using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y) 
        {
            return x - y; 
        }

        public static double Multiply(double x, double y) 
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }

        public static double Pow(double x, double y) 
        {
            double result = 1;

            if (y < 0) x = 1 / x;

            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        public static double? Sqrt(double x)
        {
            if (x < 0) return null;

            double low = 0;
            double high = x;
            double guess = x / 2;

            while ((guess*guess) -x > 0.00000000000001 || (guess * guess) - x < -0.00000000000001)
            {
                if(guess*guess < x)
                    low = guess;
                else if (guess*guess > x)
                    high = guess;

                guess = (low+high) / 2;
            }

            return guess;

        }
    }
}
