using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.That(result, Is.TypeOf<CustomerController.NotFound>());
            Assert.That(result, Is.InstanceOf<CustomerController.NotFound>());
        }
        [Test]
        public void GetCustomer_IdNotZero_ReturnNotFound()
        {
        }
    }
}
