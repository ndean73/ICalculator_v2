using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {

        private readonly int b = 16;
        
        [TestMethod()]
        public void SqrRootTest()
        {
            Assert.AreEqual(4, SquareRoot.SqrRoot(b));
        }

        
    }
}