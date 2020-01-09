using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface Isquare
    {

        public double Sqr(double a, double b);

    }
    public class Square : Isquare
    {
        private double c = 0;
        public double Sqr(double a, double b)
        {

            c = MathOperations.Square.Sqr(a, b);
            return c;
        }
    }
}
