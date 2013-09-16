using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoExercices;

namespace DojoTests
{
    [TestClass]
    public class FibonacciTests
    {
        Fibonacci fibonacci;

        [TestInitialize]
        public void Initialize()
        {
            fibonacci = new Fibonacci();
        }

        [TestMethod]
        public void fiboShouldReturn0From0()
        {
            Assert.AreEqual(fibonacci.fibo(0), 0);
        }

        [TestMethod]
        public void fibo1shouldBe1()
        {
            Assert.AreEqual(fibonacci.fibo(1), 1);
        }

        [TestMethod]
        public void fibo7shouldBe13()
        {
            Assert.AreEqual(fibonacci.fibo(7), 13);
        }
    }
}
