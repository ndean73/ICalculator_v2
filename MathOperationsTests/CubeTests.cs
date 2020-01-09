using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        //private readonly double b = 4;
        Random b = new Random();

        [TestMethod()]
        public void CubeRootTest()
        {
            // Assert.AreEqual(2, Cube.CubeRoot(b));
            Assert.AreEqual(2, Cube.CubeRoot(b.Next(1, 10)));
        }

        
    }
}