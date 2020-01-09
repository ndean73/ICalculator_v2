using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class AdditionTests
    {

        Random a = new Random();
        Random b = new Random();
       

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(5, Addition.Add(a.Next(1, 10), b.Next(1, 10)));
        }

        [TestMethod()]
        public void AddTest1()
        {
            Assert.AreEqual(3, Addition.Add(a.Next(1, 10)));
        }
    }
}