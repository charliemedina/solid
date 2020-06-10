using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ShapesTest
    {
        [TestMethod]
        public void Sum_Areas()
        {
            var rectangles = Shapes;

            double actual = AreaOperations.Sum(rectangles);

            Assert.AreEqual(expectedArea, actual);
        }

        [TestMethod]
        public void Sum_Perimeters()
        {
            var rectangles = Shapes;

            double actual = PerimeterOperations.Sum(rectangles);

            Assert.AreEqual(expectedPerimeter, actual);
        }

        [TestMethod]
        public void LSP_Test()
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 6;
            rectangle.Width = 3;

            double expected = 18;
            double actual = rectangle.Area();

            Assert.AreNotEqual(expected, actual);
        }

        private List<IGeometricShape> Shapes => new List<IGeometricShape> {
            new Rectangle { Width = 3, Height = 4 },
            new Rectangle { Width = 4, Height = 5 },
            new Rectangle { Width = 5, Height = 6 },
            new EquilateralTriangle { SideLenght = 3 }
        };

        private readonly double expectedArea = 65.89711431702997;
        private readonly double expectedPerimeter = 63;
    }

}
