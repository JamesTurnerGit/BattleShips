using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{

    public class GridReference : IGridReference
    {
        public int ThisX { get; }
        public int ThisY { get; }
        public GridContents Contents { get; set; }

        public GridReference(int x, int y, GridContents content = GridContents.empty)
        {
            ThisX = x;
            ThisY = y;
            Contents = content;
        }

        public bool Same(GridReference other)
        {
            return ThisX == other.ThisX && ThisY == other.ThisY;
        }

        public GridReference RelativePoint(int distance, Direction direction)
        {
            int x = ThisX;
            int y = ThisY;
            switch (direction)
            {
                case Direction.North:
                    x = ThisX + distance;
                    break;
                case Direction.East:
                    y = ThisY + distance;
                    break;
                case Direction.West:
                    y = ThisY - distance;
                    break;
                case Direction.South:
                    x = ThisX - distance;
                    break;
            }
            return new GridReference(x,y,GridContents.undecided);
        }
    }
}
