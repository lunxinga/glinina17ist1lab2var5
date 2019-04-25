using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assigment2Test
    {

        private Assignment2 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Assignment2();
        }
        [Test]
        [TestCase(2)]
      

        public void Home_WhenCalled_ReturnTheMassifApartaments(int FrontDoor)
        {
            var result = _math.Home(FrontDoor);

            //Проверка что массив содержит квартиру N
           Assert.That(result, Does.Contain(10));
            //Проверка что массив не пустой
            Assert.That(result, Is.Not.Empty);
            //Колличество квартир в подъезде
           Assert.That(result.Count(), Is.EqualTo(9));
            //тест будет пройден если введеное число в TestCase будет 
            //соответствовать одному из 2х подъездов и номер квартиры будет находится в массиве
            //(например:FrontDoor=1,Contain(2) -тест пройден;
            //          FrontDoor=3,Contain(2)"пустой массив" - тест не пройден;

        }
    }
}
