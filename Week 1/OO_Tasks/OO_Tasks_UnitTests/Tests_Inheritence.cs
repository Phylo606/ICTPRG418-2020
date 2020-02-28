using System;
using NUnit.Framework;
using OO_Tasks_Inheritence;

namespace OO_Tasks {
    [TestFixture]
    public class TestInheritence {
        private Square _sq1, _sq2;
        private Rectangle _rec1, _rec2;
        private Circle _cir1, _cir2;

        [SetUp]
        protected void SetUp() {
            _sq1 = new Square("Square_One", "red", 5);
            _sq2 = new Square("Square_Two", "red", 6.6);

            
            _rec1 = new Rectangle("Rectangle_One", "blue", 5, 4);
            _rec2 = new Rectangle("Rectangle_Two", "blue", 7.1, 3.5);
            
            _cir1 = new Circle("Circle_One", "black", 6);
            _cir2 = new Circle("Circle_Two", "black", 4.2);
        }

        [Test]
        public void TestSquare() {
            
            // Tests Perimeter
            Assert.AreEqual(20, _sq1.GetPerimeter());
            Assert.AreEqual(26.4, _sq2.GetPerimeter());
            
            // Tests for Area
            Assert.AreEqual(25, _sq1.GetArea()) ;
            Assert.AreEqual(43.56, _sq2.GetArea());
        }

        [Test]
        public void TestRectangle() {
            // Tests Perimeter
            Assert.AreEqual(18, _rec1.GetPerimeter());
            Assert.AreEqual(21.2, _rec2.GetPerimeter());
            
            // Tests for Area
            Assert.AreEqual(20, _rec1.GetArea()) ;
            Assert.AreEqual(24.85, _rec2.GetArea());
        }

        [Test]
        public void TestCircle() {

            double circum = Math.Round(2 * 3.142 * 6, 2);
            double area = Math.Round(6 * 6 * 3.142, 2);

            double circum2 = Math.Round(2 * 3.142 * 4.2, 2);
            double area2 = Math.Round(4.2f * 4.2 * 3.142, 2);

            
            // Tests Perimeter
            Assert.AreEqual(_cir1.GetPerimeter(), _cir1.GetCircumference());
            Assert.AreEqual(circum, _cir1.GetCircumference());
            Assert.AreEqual(circum, _cir1.GetPerimeter());
            
            Assert.AreEqual(circum2, _cir2.GetCircumference());
            Assert.AreEqual(circum2, _cir2.GetPerimeter());

            
            // Tests for Area
            Assert.AreEqual(area, _cir1.GetArea());
            
            Assert.AreEqual(area2, _cir2.GetArea());
        }
    }
}