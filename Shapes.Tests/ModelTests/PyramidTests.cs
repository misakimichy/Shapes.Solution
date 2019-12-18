using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class PyramidTests
    {
        [TestMethod]
        public void Pyramid_GetVolume_Volume()
        {
            Pyramid newPyramid = new Pyramid(3, 4, 10);
            int result = newPyramid.GetVolume();
            Assert.AreEqual(result, 40);
        }
    }
}