using NUnit.Framework;

namespace FigureLibrary.Tests
{
    [TestFixture]
    public class FugureLibraryTests
    {
        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CircleFigure(-10));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(-10, 10, 10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleFigure(3, 0, 2));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new CircleFigure(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади треугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new TriangleFigure(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new TriangleFigure(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRectangular;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new TriangleFigure(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRectangular;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
