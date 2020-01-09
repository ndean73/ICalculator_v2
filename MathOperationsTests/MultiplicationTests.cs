using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        // private readonly int a = 2;
        //   private readonly int b = 5;
        
        Random a = new Random();
        Random b = new Random();


        [TestMethod()]
        public void MultiTest()
        {
            // Assert.AreEqual(10, Multiplication.Multi(a, b));
            Assert.AreEqual(12, Multiplication.Multi(a.Next(1,12), b.Next(1,12)));
        }

        
    }
}