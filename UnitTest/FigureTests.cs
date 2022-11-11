using FigureTask;

namespace UnitTest
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void TestingTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            //Capacity triangle
            Assert.AreEqual(triangle.Get—apacity(), 6d);
            //IsRectangular
            Assert.AreEqual(triangle.IsRectangular(), true);
        }

        [TestMethod]
        public void TestingCircle()
        {
            Circle circle = new Circle(9);

            //Capacity circle
            Assert.AreEqual(circle.Get—apacity(), Math.PI * Math.Pow(9, 2));
        }
    }
}