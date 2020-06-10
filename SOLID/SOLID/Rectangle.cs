using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public class Rectangle
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }

        public static double SumAreas(IEnumerable<Rectangle> rectangles)
        {
            return rectangles.Sum(r => r.Height * r.Width);
        }

        public static double SumPerimeters(IEnumerable<Rectangle> rectangles)
        {
            return rectangles.Sum(r => 2* r.Height + 2 * r.Width);
        }
    }
}
