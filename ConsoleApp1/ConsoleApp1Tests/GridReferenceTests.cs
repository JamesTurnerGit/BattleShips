using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class GridReferenceTests
    {
        [TestMethod]
        public void CanInitialize()
        {
            var reference = new GridReference(x: 10, y: 12);
        }

        [TestMethod]
        public void CanReturnX()
        {
            var reference = new GridReference(x: 10, y: 12);
            var actual = reference.ThisX;
            Assert.AreEqual(actual, 10);
        }
        
        [TestMethod]
        public void CanReturnY()
        {
            var reference = new GridReference(x: 10, y: 12);
            var actual = reference.ThisY;
            Assert.AreEqual(actual, 12);
        }

        [TestMethod]
        public void ReturnsContent()
        {
            var reference = new GridReference(x: 10, y: 12);
            var actual = reference.Contents;
            Assert.AreEqual(actual, GridContents.undecided);
        }

        [TestMethod]
        public void SetsContentOnInit()
        {
            var reference = new GridReference(x: 10, y: 12, content: GridContents.hit);
            var actual = reference.Contents;
            Assert.AreEqual(actual, GridContents.hit);
        }

        [TestMethod]
        public void SetsContentPostInit()
        {
            var reference = new GridReference(x: 10, y: 12);
            reference.Contents = GridContents.hit;

            var actual = reference.Contents;
            Assert.AreEqual(actual, GridContents.hit);
        }


        [TestMethod]
        public void ComparePositive()
        {
            var reference = new GridReference(x: 10, y: 12);
            var reference2 = new GridReference(x: 10, y: 12);

            var actual = reference.Same(reference2);

            Assert.AreEqual(actual, true);
        }

        [TestMethod]
        public void CompareNegative()
        {
            var reference = new GridReference(x: 10, y: 12);
            var reference2 = new GridReference(x: 11, y: 12);

            var actual = reference.Same(reference2);

            Assert.AreEqual(actual, false);
        }
    }
}