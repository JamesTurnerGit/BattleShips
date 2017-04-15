using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class GridReference : IGridReference
    {
        public int ThisX { get; }
        public int ThisY { get; }
        public GridContents Contents { get; set; }

        public GridReference(int x, int y, GridContents content = GridContents.undecided)
        {
            ThisX = x;
            ThisY = y;
            Contents = content;
        }

        public bool Same(GridReference other)
        {
            return ThisX == other.ThisX && ThisY == other.ThisY;
        }
    }
}
