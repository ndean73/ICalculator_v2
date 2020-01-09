using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
       // private readonly int a = 20;
       // private readonly int b = 10;
        Random a = new Random();
        Random b = new Random();

        [TestMethod()]
        public void SubTest()
        {
            //Assert.AreEqual(10, Subtraction.Sub(a, b));
            Assert.AreEqual(4, Subtraction.Sub(a.Next(1, 10), b.Next(1, 20)));
        }

        
    }
}