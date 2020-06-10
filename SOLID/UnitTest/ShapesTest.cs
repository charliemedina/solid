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
            var rectangles = Rectangles;

            double result = AreaOperations.Sum(rectangles);

            Assert.IsTrue(result == totalAreas);
        }

        [TestMethod]
        public void Sum_Perimeters()
        {
            var rectangles = Rectangles;

            double result = PerimeterOperations.Sum(rectangles);

            Assert.IsTrue(result == totalPerimeters);
        }

        private IEnumerable<Rectangle> Rectangles => new [] {
            new Rectangle { Width = 3, Height = 4 },
            new Rectangle { Width = 4, Height = 5 },
            new Rectangle { Width = 5, Height = 6 } 
        };

        private readonly double totalAreas = 62;
        private readonly double totalPerimeters = 54;
    }

}
