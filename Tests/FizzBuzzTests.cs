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
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;
        
        [TestInitialize]
        public void Initialize()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void shouldReturnFizzFrom3()
        {
            Assert.AreEqual(fizzBuzz.CheckFizzBuzz(3), "Fizz");
        }

        [TestMethod]
        public void shouldReturnBuzzFrom5()
        {
            Assert.AreEqual(fizzBuzz.CheckFizzBuzz(5), "Buzz");
        }

        [TestMethod]
        public void shouldReturn2from2()
        {
            Assert.AreEqual(fizzBuzz.CheckFizzBuzz(2), "2");
        }

        [TestMethod]
        public void shouldReturnFizzBuzzFrom15()
        {
            Assert.AreEqual(fizzBuzz.CheckFizzBuzz(15), "FizzBuzz");
        }
    }
}
