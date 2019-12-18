using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetCircumference_Circumference()
        {
            Circle newCircle = new Circle(10);
            double result = newCircle.GetCircumference();
            Assert.AreEqual(result, (2 * Math.PI * 10));
        }

        [TestMethod]
        public void Circle_GetDiameter_Diameter()
        {
            Circle newCircle = new Circle(5);
            int result = newCircle.GetDiameter();
            Assert.AreEqual(result, 10);
        }
    }
}