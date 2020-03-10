using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    class DriverTests
    {
        Driver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new Driver("Alan", "Smithee", "Male", "Probationary");
        }

        [Test]
        public void DriverConstructor_IsCalled_AttributesSet()
        {
            Assert.That(_driver.fname.Equals("Alan"));
            Assert.That(_driver.lname.Equals("Smithee"));
            Assert.That(_driver.getGender().Equals("Male"));
            Assert.That(_driver.getLicenceType().Equals("Probationary"));
        }

        [Test]
        public void GetLicenseType_IsCalled_ReturnsCorrectValue()
        {
            Assert.That(_driver.getLicenceType().Equals("Probationary"));
        }
    }
}
