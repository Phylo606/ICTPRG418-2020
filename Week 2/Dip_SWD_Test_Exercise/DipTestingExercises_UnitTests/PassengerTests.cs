using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    class PassengerTests
    {
        Passenger _passenger;

        [SetUp]
        public void Setup()
        {
            _passenger = new Passenger("Jackie", "Chan", "Male", "Concession");
        }

        [Test]
        public void PassengerConstructor_IsCalled_AttributesSet()
        {
            Assert.That(_passenger.fname.Equals("Jackie"));
            Assert.That(_passenger.lname.Equals("Chan"));
            Assert.That(_passenger.getGender().Equals("Male"));
            Assert.That(_passenger.getTicketType().Equals("Concession"));
        }

        [Test]
        public void GetTicketType_IsCalled_ReturnsCorrectValue()
        {
            Assert.That(_passenger.getTicketType().Equals("Concession"));
        }
    }
}
