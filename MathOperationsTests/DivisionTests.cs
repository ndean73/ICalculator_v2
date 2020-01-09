using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    
    [TestClass()]
    public class DivisionTests
    {
        //private readonly int a = 20;
        // private readonly int b = 10;
        Random a = new Random();
        Random b = new Random();

        [TestMethod()]
        public void DivTest()
        {
            // Assert.AreEqual(2, Division.Div(a, b));
            Assert.AreEqual(2, Division.Div(a.Next(1, 20), b.Next(1, 10)));
        }

        public void DivDoubleTest()
        {
           // Assert.AreEqual(2, Division.Div(a, b));
        }

    }
}