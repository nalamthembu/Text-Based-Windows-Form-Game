using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y, TileEnum.OBSTACLE) { }
    }
}
