using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests.Lab1
{
    [TestFixture]
    public class Math_Lab1Tests
    {

        private Math_Lab1 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }
        [Test]
        [TestCase(5, 5,true)]
        [TestCase(1, 5,false)]
        [TestCase(1, 10,true)]

        public void MultiplicationGreaterThan10_WhenCalledTestPassed_ReturnResult(int a, int b, bool Result)
        {
            var result = _math.MultiplicationGreaterThan10(a, b);
            Assert.That(result, Is.EqualTo(Result));
        }
        [Test]
        [TestCase(1, 5, true)]
        [TestCase(5, 5, false)]
        [TestCase(5, 1, true)]

        public void MultiplicationGreaterThan10_WhenCalledTestFaled_ReturnResult(int a, int b, bool Result)
        {
            var result = _math.MultiplicationGreaterThan10(a, b);
            Assert.That(result, Is.EqualTo(Result));
        }
        
    }
}
