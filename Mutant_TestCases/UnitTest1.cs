using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class Shijitha_Sandeep_TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage1()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Arrange
            int firstAngle = 100;
            int secondAngle = 30;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_SumNotEqualTo180_ReturnsInvalidMessage3()
        {
            // Arrange
            int firstAngle = 10;
            int secondAngle = 30;
            int thirdAngle = 5;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_ZeroAngles_ReturnsInvalidMessage4()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_NegativeAngles_ReturnsInvalidMessage5()
        {
            // Arrange
            int firstAngle = -120;
            int secondAngle = -30;
            int thirdAngle = -30;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_GreaterThan180Angles_ReturnsInvalidMessage6()
        {
            // Arrange
            int firstAngle = 190;
            int secondAngle = 190;
            int thirdAngle = 190;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_SumOf2TraingleIs180_ReturnsInvalidMessage7()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_IsoscelesTraingle_ReturnsValidMessage8()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 45;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_SumEqualTo180WithDifferentAngles_ReturnsValidMessage9()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 30;
            int thirdAngle = 80;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_WithOneAngle180_ReturnsInvalidMessage10()
        {
            // Arrange
            int firstAngle = 180;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_WithOneAngleGreaterThan180_ReturnsInvalidMessage11()
        {
            // Arrange
            int firstAngle = 190;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_WithOneAngleLessThan180_ReturnsInvalidMessage12()
        {
            // Arrange
            int firstAngle = 170;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
    }
}
