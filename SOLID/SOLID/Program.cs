using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shapes

            var shapes = new IGeometricShape[] {
                new Rectangle { Width = 3, Height = 4 },
                new Rectangle { Width = 4, Height = 5 },
                new Rectangle { Width = 5, Height = 6 },
                new EquilateralTriangle { SideLenght = 3 }
            };

            var calculator = new ShapesCalculator();
            calculator.Calculate(shapes);
            Console.WriteLine($"Total area: {calculator.TotalAreas} \n" +
                              $"Total perimeter: {calculator.TotalPerimeters}");

            Console.ReadKey();

        #endregion
    }
    }
}
