using System.Collections.Generic;

namespace BattleShips
{
    public interface IGrid
    {
        int MaxX { get; }
        int MaxY { get; }

        void AddPointOfInterest(GridReference reference);
        List<GridReference> GetPointsOfInterest();
    }
}