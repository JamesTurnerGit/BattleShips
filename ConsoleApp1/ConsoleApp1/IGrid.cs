using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IGrid
    {
        int MaxX { get; }
        int MaxY { get; }

        void AddPointOfInterest(GridReference reference);
        List<GridReference> GetPointsOfInterest();
    }
}