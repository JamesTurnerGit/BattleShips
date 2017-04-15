using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    public class Ship
    {
        public int health { get; private set;}
        private Grid grid;

        public Ship(Grid MyGrid, GridReference startPoint, int length, Direction direction)
        {
            health = length;
            grid = MyGrid;

            List<GridReference> shipLocations = new List<GridReference>();

            shipLocations.Add(makeGridReference(startPoint.ThisX, startPoint.ThisY));

            for (int i = 1; i == length; i++)
            {

            }

            AddShipToGrid(shipLocations);
        }

        private GridReference makeGridReference(int x, int y)
        {
            var point = new GridReference(x, y, GridContents.boat);
            if (grid.ReferenceIsEmpty(point)) { throw new ArgumentException("Place already taken"); }
            if (grid.ReferenceIsInRange(point)) { throw new ArgumentException("That goes off the board"); }
            return point;
        }

        private void AddShipToGrid(List<GridReference> Points) {
            foreach (var point in Points)
            {
                grid.AddPointOfInterest(point);
            }
        }

        public void TakeDamage ()
        {
            health -= 1;
        }

        public bool IsDead()
        {
            return health == 0;
        }
    }
}
