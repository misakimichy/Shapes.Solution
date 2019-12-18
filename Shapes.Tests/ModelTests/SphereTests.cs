using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Sphere_GetVolume_Volume()
        {
            Sphere newSphere = new Sphere(5);
            double result = newSphere.GetVolume();
            Assert.AreEqual(result, (4 / 3 * Math.PI * Math.Pow(5, 3)));
        }

        [TestMethod]
        public void Sphere_GetSurfaceArea_SurfaceArea()
        {
            Sphere newSphere = new Sphere(5);
            double result = newSphere.GetSurfaceArea();
            Assert.AreEqual(result, (4 * Math.PI * 5));
        }
    }
}