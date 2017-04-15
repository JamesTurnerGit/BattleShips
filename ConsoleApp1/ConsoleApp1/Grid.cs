using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Grid : IGrid
    {
        public int MaxX { get; private set; }
        public int MaxY { get; private set; }

        List<GridReference> PointsOfInterest = new List<GridReference>();
 
        public Grid (int maxX = 20, int maxY = 20)
        {
            MaxX = maxX;
            MaxY = maxY;
        }

        public List<GridReference> GetPointsOfInterest()
        {
            return PointsOfInterest;
        }

        public void AddPointOfInterest(GridReference reference)
        {
            if (!ReferenceIsInRange(reference)){
                throw new ArgumentOutOfRangeException("Outside of grid Reference");}
            if (!ReferenceHasValidContents(reference)){
                throw new ArgumentException("Reference has invalid contents");}
            PointsOfInterest.Add(reference);
            
        }
        
        bool ReferenceIsInRange(GridReference reference)
        {
            var testX = reference.ThisX;
            var testY = reference.ThisY;
            if (MaxX < testX || testX < 0) { return false; }
            if (MaxY < testY || testY < 0) { return false; }
            return true;
        }

        bool ReferenceHasValidContents(GridReference reference)
        {
            return !(reference.Contents == GridContents.undecided);
        }
    }
}
