using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assigment3Test
    {
        [Test]
        public void IsLetter_WhenCalled_ReturnMatches()
        {
            var Assignment​ = new Assignment​3();
            var result = Assignment​.IsLetter('А', "Авв");
            //проверяем тип возвращаемой функции  Matches
            Assert.That(result, Is.TypeOf<matches>());
            //тест будет пройден если введеный символ будет содержатся в строке 
            //                               например:('А', "Авв"),TypeOf<matches> -тест пройден;
            //                                         ('с', "Авв"),TypeOf<matches> - тест не пройден;

        }

    }
}
