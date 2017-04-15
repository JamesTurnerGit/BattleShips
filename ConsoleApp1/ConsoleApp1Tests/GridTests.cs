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
    public class GridTests
    {
        [TestMethod]
        public void CanInitialize()
        {
            var grid = new Grid();
        }

        [TestMethod]
        public void CanReturnMaxX()
        {
            var grid = new Grid(maxX: 10);
            int actual = grid.MaxX;
            Assert.AreEqual(actual, 10);
        }

        [TestMethod]
        public void CanReturnMaxY()
        {
            var grid = new Grid(maxY: 10);
            int actual = grid.MaxY;
            Assert.AreEqual(actual, 10);
        }

        [TestMethod]
        public void CanAddPointsOfInterest()
        {
            
            Grid grid = new Grid();
            Console.Write(GridContents.hit);
            GridReference point = new GridReference(x: 1,y: 1,content: GridContents.hit);

            Console.Write(point);

            grid.AddPointOfInterest(reference: point);

            GridReference actual = grid.GetPointsOfInterest()[0];
            Assert.AreEqual(actual, point);
        }

        [TestMethod]
        public void CantAddPointsOfInterestOutsideRange()
        {

            Grid grid = new Grid();
            Console.Write(GridContents.hit);
            GridReference point = new GridReference(x: -5, y: -5, content: GridContents.hit);

            Console.Write(point);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => grid.AddPointOfInterest(reference: point));
        }

        [TestMethod]
        public void CantAddPointsOfInterestWithBadContents()
        {

            Grid grid = new Grid();
            Console.Write(GridContents.hit);
            GridReference point = new GridReference(x: 5, y: 5, content: GridContents.undecided);

            Console.Write(point);

            Assert.ThrowsException<ArgumentException>(() => grid.AddPointOfInterest(reference: point));
        }
    }
}