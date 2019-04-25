using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assigment4Test
    {
        [Test]

        public void Area_WhenCalled_ArealessNumber()
        {
            var area = new Assignment4();
           var s= 0;
            area.Area(10,5,out s);
            //проверяем ,чтобы площадь была меньше или равна 50
            Assert.That(s >= 50);
            //если площадь прямоугольника меньше или равна 50 тест проходит, если больше
            //тест не пройдет
        }
    }
}

    