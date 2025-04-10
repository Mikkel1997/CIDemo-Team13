using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo_Team13
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            checked // For at håndtere overflow
            {
                return a + b;
            }
        }

        public int Subtract(int a, int b)
        {
            checked // For at håndtere overflow
            {
                return a - b;
            }
        }

        public int Multiply(int a, int b)
        {
            checked // For at håndtere overflow
            {
                return a * b;
            }
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division med nul er ikke tilladt");
            }

            return a / b;
        }

        public double Power(double a, double b)
        {
            if (a == 0 && b <= 0)
            {
                throw new ArgumentException("Ugyldig eksponentiation: 0^0 eller 0 til negativ eksponent");
            }
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Kvadratroden af et negativt tal er ikke defineret i reelle tal");
            }
            return Math.Sqrt(a);
        }
    }
}
