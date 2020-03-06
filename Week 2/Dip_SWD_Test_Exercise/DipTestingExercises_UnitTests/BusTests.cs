using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    class BusTests
    {
        Driver _driver;
        Bus _bus;
        Passenger _passenger;
        FakeMotorVehicle _motorvehicle;
        FakeIPerson _person;

        [SetUp]
        public void Setup()
        {
            _driver = new Driver("John", "Doe", "Male", "Probationary");
            _bus = new Bus(_driver, 100, 50, 2, 1);
            _passenger = new Passenger("Alan", "Smithee", "Male", "Concession");
            _motorvehicle = new FakeMotorVehicle(_person, 100, 50, 2);
            _person = new FakeIPerson();
        }

        [Test]
        public void BusConstructor_IsCalled_AttributesSet()
        {
            Assert.That(_bus.maxPassengers.Equals(1));
        }
        [Test]
        public void GetPassengerCount_IsCalled_NoPassengers()
        {
            Assert.That(_bus.getPassengerCount().Equals(0));
        }
        [Test]
        public void GetPassengerCount_IsCalled_ReturnsCorrectValue()
        {
            _bus.passengers.Add(_passenger);
            Assert.That(_bus.getPassengerCount().Equals(1));
        }
        [Test]
        public void EmbarkPassenger_IsCalled_PassengerAdded()
        {
            _bus.embarkPassenger(_passenger);
            Assert.That(_bus.passengers.Contains(_passenger));
        }
        [Test]
        public void EmbarkPassenger_IsCalled_ThrowsException()
        {
            try
            {
                _bus.embarkPassenger(_passenger);
                _bus.embarkPassenger(_passenger);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.ToLower().Contains("bus"));
                Assert.That(e.Message.ToLower().Contains("full"));
            }
        }
    }
}
