using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public interface IGeometricShape
    {
        double Area();
        double Perimeter();
    }

    public class Rectangle : IGeometricShape
    {
        public int Sides { get; } = 4;
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return 2 * Height + 2 * Width;
        }
    }

    public class EquilateralTriangle : IGeometricShape
    {
        public int Sides { get; } = 3;
        public double SideLenght { get; set; }

        public double Area()
        {
            return Math.Pow(SideLenght, 2) * Math.Sqrt(3) / 4;
        }

        public double Perimeter()
        {
            return 3 * SideLenght;
        }
    }

    public class AreaOperations
    {
        public static double Sum(IEnumerable<IGeometricShape> shapes)
        {
            return shapes.Sum(s => s.Area());
        }
    }

    public class PerimeterOperations
    {
        public static double Sum(IEnumerable<IGeometricShape> shapes)
        {
            return shapes.Sum(s => s.Perimeter());
        }
    }

    public class Square : Rectangle
    {
        private double _height;
        private double _width;

        public override double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;

            }
        }
    }
}
