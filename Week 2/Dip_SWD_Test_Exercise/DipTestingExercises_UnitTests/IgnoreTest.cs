using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    class IgnoreTest
    {
        Bus _bus;
        IPerson _iperson;
        Passenger _passenger;

        [SetUp]
        public void Setup()
        {
            _bus = new Bus(_iperson, 20, 10, 2, 10);
        }

        [Test]
        [Ignore("Ignore Test")]
        public void GetPassengerCount_IsCalled_ReturnsCorrectValue()
        {
            _bus.passengers.Add(_passenger);
            Assert.That(_bus.getPassengerCount().Equals(1));
        }
    }
}
