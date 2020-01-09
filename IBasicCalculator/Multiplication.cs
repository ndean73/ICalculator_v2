using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface Imultiplication
    {

        public double Multi(double a, double b);

    }
    public class Multiplication : Imultiplication
    {
        private double c = 0;
        public double Multi(double a, double b)
        {

            c = MathOperations.Multiplication.Multi(a, b);
            return c;
        }
    }
}
