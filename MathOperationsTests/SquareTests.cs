using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        // private readonly double a = 2;
        // private readonly double b = 4;

        Random a = new Random();
        Random b = new Random();
        [TestMethod()]
        public void SqrTest()
        {
            // Assert.AreEqual(16, Square.Sqr(a,b));
            Assert.AreEqual(2, Square.Sqr(a.Next(1, 10), b.Next(1, 10)));

        }

        
    }
}