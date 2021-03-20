using OOP;
using Xunit;

namespace XUnitTestTasks
{
    public class OOPTests
    {

        [Theory]
        [InlineData(20, 1256.6370614359173)]
        [InlineData(12.5, 490.8738521234052)]
        [InlineData(3.55, 39.59192141686537)]
       

        public void TestCircleArea(double radius, double expected)
        {
            Circle circle = new Circle(radius);
            var actual = circle.GetArea();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,2, 40)]
        [InlineData(12.5,2, 25)]
        [InlineData(3.55,2, 7.1)]


        public void TestRectangleArea(double width, double height, double expected)
        {
            Rectangle rectangle = new Rectangle( width,  height);
            var actual = rectangle.GetArea();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 400)]
        [InlineData(12.5, 156.25)]
        [InlineData(3.55, 12.6025)]


        public void TestSquareArea(double side, double expected)
        {
            Square square = new Square(side);
            var actual = square.GetArea();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,3, 30)]
        [InlineData(12.5,3, 18.75)]
        [InlineData(3.55,3, 5.324999999999999)]


        public void TestTriangleArea(double Base, double height, double expected)
        {
            Triangle triangle = new Triangle(Base, height);
            var actual = triangle.GetArea();

            Assert.Equal(expected, actual);
        }
    }
}
