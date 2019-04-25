using TestNinja.Fundamentals;
using NUnit.Framework;
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTest
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo ("a"));
           // Assert.That(() => logger.LastError, Throws.ArgumentNullException);
        }
    }
}
