using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shapes

            var calculator = new ShapesCalculator();
            calculator.Calculate();
            Console.WriteLine($"Total area: {calculator.TotalAreas} \n" +
                              $"Total perimeter: {calculator.TotalPerimeters}");
            Console.ReadKey();

            #endregion
        }
    }
}
