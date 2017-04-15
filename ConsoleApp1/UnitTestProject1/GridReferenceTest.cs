using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class GridReferenceTest
    {
        [TestMethod]
        public void CanReturnGrid()
        {
            //double for grid
        }

        [TestMethod]
        public void CanInitialize()
        {
            var reference = new GridReference(x: 10,y:12);
        }

        [TestMethod]
        public void CanReturnX()
        {
            var reference = new GridReference(x: 10, y: 12);
            var actual = reference.thisX;
            Assert.AreEqual(actual, 10);
        }


        [TestMethod]
        public void CanReturnY()
        {
            var reference = new GridReference(x: 10, y: 12);
            var actual = reference.thisY;
            Assert.AreEqual(actual, 12);
        }
    }
}