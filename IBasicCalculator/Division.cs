using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface Idivision
    {
        public int Div(int a, int b);
    }
    public class Division : Idivision
    {
        private int c = 0;
        public int Div(int a, int b)
        {

            c = MathOperations.Division.Div(a, b);
            return c;
        }
    }
}
