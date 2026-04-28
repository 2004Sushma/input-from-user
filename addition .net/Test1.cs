using NUnit.Framework;
using CalculatorApp;
using System;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.AreEqual(6, calc.Multiply(2, 3));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.AreEqual(2, calc.Divide(4, 2));
        }

        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(4, 0));
        }
    }
}