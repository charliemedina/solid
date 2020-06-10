using System;
using System.Collections.Generic;

namespace SOLID
{
    public class Rectangle
    {
        public int Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class EquilateralTriangle
    {
        public int Sides { get; } = 3;
        public double SideLenght { get; set; }
    }

    public class AreaOperations
    {
        public static double Sum(IEnumerable<object> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle rectangle)
                {
                    area += rectangle.Height * rectangle.Width;
                }
                else if (shape is EquilateralTriangle triangle)
                {
                    area += Math.Pow(triangle.SideLenght, 2) * Math.Sqrt(3) / 4;
                }
            }
            return area;
        }
    }

    public class PerimeterOperations
    {
        public static double Sum(IEnumerable<object> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle rectangle)
                {
                    area += 2 * rectangle.Height + 2 * rectangle.Width;
                }
                else if (shape is EquilateralTriangle triangle)
                {
                    area += 3 * triangle.SideLenght;
                }
            }
            return area;
        }
    }
}
