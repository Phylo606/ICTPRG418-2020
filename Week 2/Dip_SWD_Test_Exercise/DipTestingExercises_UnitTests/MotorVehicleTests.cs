using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    public class MotorVehicleTests
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
            _bus = new Bus(_person, 100, 50, 2, 1);
            _passenger = new Passenger("Alan", "Smithee", "Male", "Concession");
            _motorvehicle = new FakeMotorVehicle(_person, 100, 50, 2);
            _person = new FakeIPerson();
        }

        [Test]
        public void MotorvehicleConstructer_IsCalled_AttributesSet()
        {
            Assert.That(_motorvehicle.maxFuel.Equals(100));
            Assert.That(_motorvehicle.currentFuel.Equals(50));
            Assert.That(_motorvehicle.litresPerKM.Equals(2));
        }

        [Test]
        public void GetFuelRemaining_IsCalled_ReturnsCorrectValue()
        {
             Assert.That(_motorvehicle.getFuelRemaining().Equals(50));
        }

        [Test]
        public void Refuel_HasEnoughRoom_CurrentFuelUpdatedCorrectly()
        {
            _motorvehicle.refuel(50);
            Assert.That(_motorvehicle.currentFuel.Equals(100));
        }

        [Test]
        public void Refuel_DoesNotHaveEnoughRoom_ThrowsException()
        {
            try
            {
                _motorvehicle.refuel(51);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.ToLower().Contains("cannot hold that much fuel"));
            }
        }

        [Test]
        public void Refuel_AttemptToAddNegativeFuel_ThrowsException()
        {
            try
            {
                _motorvehicle.refuel(-1);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.ToLower().Contains("stealing fuel"));
            }
        }
        [Test]
        public void Travel_HasEnoughFuel_ReturnsCorrectValue()
        {
            _motorvehicle.travel(10);
            Assert.That(_motorvehicle.getFuelRemaining().Equals(30));
        }
        [Test]
        public void Travel_DoesNotHaveEnoughFuel_ThrowsException()
        {
            
            try
            {
                _motorvehicle.travel(26);
                Assert.Fail();
                _motorvehicle.getFuelRemaining();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.ToLower().Contains("out of fuel"));
                Assert.That(_motorvehicle.getFuelRemaining().Equals(0));
            }

        }
    }

    public class FakeMotorVehicle : MotorVehicle
    {
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM)
        {

        }
    }
    public class FakeIPerson : IPerson
    {
        public string getGender()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }
    }
    public class FakePerson : Person
    {
        public FakePerson(string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        {

        }
    }
}