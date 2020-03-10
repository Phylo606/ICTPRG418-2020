using System;
using NUnit.Framework;
using DipTestingExercises;

namespace DipTestingExercises_UnitTests
{
    class PersonTests
    {
        FakePerson _person;

        [SetUp]
        public void Setup()
        {
            _person = new FakePerson("John", "Smith", "Male");
        }

        [Test]
        public void PersonConstructor_IsCalled_AttributesSet()
        {
            Assert.That(_person.fname.Equals("John"));
            Assert.That(_person.lname.Equals("Smith"));
            Assert.That(_person.getGender().Equals("Male"));
        }
        
        [Test]
        public void GetName_IsCalled_ReturnsCorrectValue()
        {
            Assert.That(_person.getName().Equals("John Smith"));
        }
        
        [Test]
        public void GetGender_IsCalled_ReturnsCorrectValue()
        {
            Assert.That(_person.getGender().Equals("Male"));
        }
    }
}
