namespace SOLID
{
    public class ShapesCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public void Calculate()
        {
            var shapes = new IGeometricShape[]
            {
                new Rectangle { Width = 3, Height = 4 },
                new Rectangle { Width = 4, Height = 5 },
                new Rectangle { Width = 5, Height = 6 },
                new EquilateralTriangle { SideLenght = 3 }
            };

            var areaOperations = new AreaOperations();
            var perimeterOperations = new PerimeterOperations();

            TotalAreas = areaOperations.Sum(shapes);
            TotalPerimeters = perimeterOperations.Sum(shapes);
        }
    }
}
