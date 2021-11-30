using System;

namespace FinalPOE
{
	[Serializable]
	public class Gold : Item
	{
		private int goldAmount = 0;
		public int GoldAmount
		{
			get { return goldAmount; }
			set { goldAmount = value; }
		}

		private static Random r = new Random();

		public Gold(int x, int y) : base(x, y, TileEnum.GOLD)
		{
			this.x = x;
			this.y = y;
			tileType = TileEnum.GOLD;
			goldAmount = r.Next(1, 6);
		}

		public override string ToString()
		{
			return GetType().Name;
		}
	}
}