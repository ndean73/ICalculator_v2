using System;
using MathOperations;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface ICube {

        public double cube(double a);
    }
    public class Cube:ICube
    {
        private double a = 0;

        public double cube(double a)
        {
            a = MathOperations.Cube.CubeRoot(a);
            return a;
        }
    }
}
