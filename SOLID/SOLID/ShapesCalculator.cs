using System.Collections;
using System.Collections.Generic;

namespace SOLID
{
    public class ShapesCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public void Calculate(IEnumerable<IGeometricShape> shapes)
        {
            var areaOperations = new AreaOperations();
            var perimeterOperations = new PerimeterOperations();

            TotalAreas = areaOperations.Sum(shapes);
            TotalPerimeters = perimeterOperations.Sum(shapes);
        }
    }
}
