using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBasicCalculator.Tests
{
    
    [TestClass()]
    public class BasicCalculatorTests
    {
        BasicCalculator calc = new BasicCalculator();
        

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(12,calc.Add(5,7));
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(2, calc.Cube(5));
        }

        [TestMethod()]
        public void DivTest()
        {
            Assert.AreEqual(1, calc.Div(5,3));
        }

        [TestMethod()]
        public void MultiTest()
        {
            Assert.AreEqual(45, calc.Multi(15,3));
        }

        [TestMethod()]
        public void SqrTest()
        {
            Assert.AreEqual(15625, calc.Sqr(5,6));
        }

        [TestMethod()]
        public void SqrRootTest()
        {
            Assert.AreEqual(4, calc.SqrRoot(16));
        }

        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(6, calc.Sub(16,10));
        }

        
    }
}