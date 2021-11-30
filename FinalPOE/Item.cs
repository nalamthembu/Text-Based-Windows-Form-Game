using System;

namespace FinalPOE
{
	[Serializable]
	public abstract class Item : Tile
	{
		public Item(int x, int y, TileEnum tileType) : base (x,y, tileType)
		{
			this.x = x;
			this.y = y;
			this.tileType = tileType;
		}
	}
}
