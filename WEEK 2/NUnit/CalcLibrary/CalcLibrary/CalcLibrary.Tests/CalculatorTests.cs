using NUnit.Framework;
using System;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator.AllClear();
        }

        [Test]
        public void Addition_TwoNumbers_ReturnsCorrectSum()
        {
            double result = _calculator.Addition(5, 7);
            Assert.That(result, Is.EqualTo(12));
            Assert.That(_calculator.GetResult, Is.EqualTo(12));
        }

        [Test]
        public void Subtraction_TwoNumbers_ReturnsCorrectDifference()
        {
            double result = _calculator.Subtraction(10, 4);
            Assert.That(result, Is.EqualTo(6));
            Assert.That(_calculator.GetResult, Is.EqualTo(6));
        }

        [Test]
        public void Multiplication_TwoNumbers_ReturnsCorrectProduct()
        {
            double result = _calculator.Multiplication(3, 4);
            Assert.That(result, Is.EqualTo(12));
            Assert.That(_calculator.GetResult, Is.EqualTo(12));
        }

        [Test]
        public void Division_TwoNumbers_ReturnsCorrectQuotient()
        {
            double result = _calculator.Division(8, 2);
            Assert.That(result, Is.EqualTo(4));
            Assert.That(_calculator.GetResult, Is.EqualTo(4));
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }

        [Test]
        public void AllClear_ResetsResultToZero()
        {
            _calculator.Addition(10, 5);  // Sets result to 15
            _calculator.AllClear();
            Assert.That(_calculator.GetResult, Is.EqualTo(0));
        }
    }
}
