using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalledShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.stringFormatAsBold("abc");
            //specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            //more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        }
    }
}
