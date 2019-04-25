
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Assigment1Test
    {

        private Assignment1 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Assignment1();
        }
        [Test]
        [TestCase(2)]
 
        public void Party_WhenCalled_ReturnTheStringParty(int number)
        {
            var result = _math.party(number);
            //StartWith  проверяет на совпадение начало строки,функция ​IgnoreCase 
            //позволяет не учитывать регистр
            Assert.That(result, Does.StartWith("чётное").IgnoreCase);
            //тест будет пройден если введеное число в TestCase и текст будут 
            //соответствовать условию функции(например:number=3,"Не чётное" -тест пройден;
            //                                         number=3,"чётное" - тест не пройден;
        }
    }
}
