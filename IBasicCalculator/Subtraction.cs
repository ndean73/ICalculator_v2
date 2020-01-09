using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface Isubtraction
    {

        public int Sub(int a, int b);

    }
    public class Subtraction : Isubtraction
    {
        private int c = 0;
        public int Sub(int a, int b)
        {

            c = MathOperations.Subtraction.Sub(a, b);
            return c;
        }

        
    }
}
