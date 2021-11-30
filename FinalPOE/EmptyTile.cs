using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    public class EmptyTile : Tile
    {
        public EmptyTile (int x, int y) : base (x,y, TileEnum.EMPTY){}
    }
}
