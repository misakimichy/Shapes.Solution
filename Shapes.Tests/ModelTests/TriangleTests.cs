using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_GetPerimeter_Perimeter()
        {
            Triangle newTriangle = new Triangle(3, 4, 5);
            int result = newTriangle.GetPerimeter();
            Assert.AreEqual(result, 12);
        }
    }
}