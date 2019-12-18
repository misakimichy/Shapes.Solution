using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public int Radius { get; set; }
        public Sphere(int radius)
        {
            Radius = radius;
        }

        public double GetVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }

        public double GetSurfaceArea()
        {
            return 4 * Math.PI * Radius;
        }
    }
}