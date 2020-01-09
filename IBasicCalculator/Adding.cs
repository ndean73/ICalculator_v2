using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator
{
    public interface Iadding {

        public int Add(int a,int b);

    }
    public class Adding: Iadding
    {
        private int c = 0;
        public int Add(int a, int b)
        {

            c = MathOperations.Addition.Add(a,b);
            return c;
        }
    }
}
