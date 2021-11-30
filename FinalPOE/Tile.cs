using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    public enum TileEnum
    {
        HERO, ENEMY, GOLD, WEAPON, OBSTACLE, EMPTY
    }

    [Serializable]
    public abstract class Tile
    {
        protected int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        protected TileEnum tileType;

        public TileEnum Tile_Type { get { return tileType; } }

        public Tile(int x, int y, TileEnum tileType)
        {
            this.x = x;
            this.y = y;
            this.tileType = tileType;
        }
    }
}
