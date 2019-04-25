using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
            Assert.That(result,Is.True);
            Assert.That(result==true);
        }

        [Test]
        public void CanBeCancalledBy_UserReservation_ReturnsTrue()
        {   //Arrange
            var reservation = new Reservation();

            //Act
            User UserReservation = new User();
            reservation.MadeBy = UserReservation;
            var result = reservation.CanBeCancelledBy(UserReservation);

            //Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancalledBy_Other_ReturnsFalse()
        { 
            //Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            //Assert
            Assert.IsFalse(result);
            Assert.That(result, Is.False);
            Assert.That(result == false);
        }
    }
}
