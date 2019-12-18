using System;

namespace Shapes.Models
{
    public class Circle
    {
        public int Radius { get; set; }

        public Circle (int radius)
        {
            Radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public int GetDiameter()
        {
            return 2 * Radius;
        }
    }
}