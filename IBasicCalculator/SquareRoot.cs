using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface IsquareRoot
    {

        public int SqrRoot(int a);

    }
    public class SquareRoot : IsquareRoot
    {
        private int c = 0;
        public int SqrRoot(int a)
        {
            c = MathOperations.SquareRoot.SqrRoot(a);
            return c;
        }
    }
}

