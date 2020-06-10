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

            double result = AreaOperations.Sum(rectangles);

            Assert.AreEqual(expectedArea, result);
        }

        [TestMethod]
        public void Sum_Perimeters()
        {
            var rectangles = Shapes;
                
            double result = PerimeterOperations.Sum(rectangles);

            Assert.AreEqual(expectedPerimeter, result);
        }

        private List<object> Shapes => new List<object> {
            new Rectangle { Width = 3, Height = 4 },
            new Rectangle { Width = 4, Height = 5 },
            new Rectangle { Width = 5, Height = 6 },
            new EquilateralTriangle { SideLenght = 3 }
        };

        private readonly double expectedArea = 65.89711431702997;
        private readonly double expectedPerimeter = 63;
    }

}
