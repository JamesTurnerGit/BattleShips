using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    public class Grid : IGrid
    {
        public int MaxX { get; private set; }
        public int MaxY { get; private set; }

        List<GridReference> PointsOfInterest = new List<GridReference>();

        public Grid(int maxX = 20, int maxY = 20)
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
            if (!ReferenceIsInRange(reference)) {
                throw new ArgumentOutOfRangeException("Outside of grid Reference"); }
            PointsOfInterest.Add(reference);
        }
    
        public void UpdatePointOfInterest(GridReference reference, GridContents newContent)
        {
            PointAtLocation(reference).Contents = newContent;
        }

        public GridReference PointAtLocation(GridReference reference)
        {
            var point = PointsOfInterest.Find(item => item.Same(reference));
            if (point == null)
                {
                    AddPointOfInterest(reference);
                    return reference;
                }else{
                    return point;
                }
        }

        public GridContents ContentAtLocation(GridReference reference)
        { 
            return PointAtLocation(reference).Contents;
        }

        public bool ReferenceIsEmpty(GridReference reference)
        {
            if (ContentAtLocation(reference) == GridContents.empty) { return true; }
            return false;
        }
        
        public bool ReferenceIsInRange(GridReference reference)
        {
            var testX = reference.ThisX;
            var testY = reference.ThisY;
            if (MaxX < testX || testX < 0) { return false; }
            if (MaxY < testY || testY < 0) { return false; }
            return true;
        }
    }
}
