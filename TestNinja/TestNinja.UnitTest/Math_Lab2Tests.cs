using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Math_Lab2Tests
    {
        
        private Math_Lab2 _math;

        [SetUp]
        public void SetUp()
      {
        _math=new Math_Lab2();
      }
       [Ignore("Для быстрой обработки других тестов")]
        [Test]
        [TestCase(5, 4, 5)]
        [TestCase(3, 7, 7)]
        [TestCase(8, 8, 8)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult )
        {
           // var math = new Math_Lab2();
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Ignore("Для быстрой обработки других тестов")]
        [Test]
        [TestCase(5, 4, 9)]
        [TestCase(3, 7, 10)]
        [TestCase(8, 8, 16)]
        public void Add_WhenCalledTestPassed_ReturnTheSumArgument(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Ignore("Для быстрой обработки других тестов")]
        [Test]
        [TestCase(5, 4, 1)]
        [TestCase(3, 7, 0)]
        [TestCase(8, 8, 2)]
        public void Add_WhenCalledTestFaled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]

        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Проверка что массив не пустой
            Assert.That(result, Is.Not.Empty);

            //Колличество элементов в массиве =3
            Assert.That(result.Count(), Is.EqualTo(3));

            //Проверка что массив содержит число 1
            Assert.That(result, Does.Contain(1));

            //Проверка что массив содержит число 3
            Assert.That(result, Does.Contain(3));

            //Проверка что массив содержит число 5
            Assert.That(result, Does.Contain(5));

            //Проверка на совпадение всего массива целиком
            Assert.That(result, Is.EquivalentTo(new[] { 1,3,5}));

            //Проверка что весь массив отсартирован
            Assert.That(result, Is.Ordered);

            //Проверка массива на уникальность
            Assert.That(result, Is.Unique);
        }
    }
}
