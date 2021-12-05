using System;

namespace FinalPOE
{
    [Serializable]
    public abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;
        public char symbol;

        public int Damage { get { return damage; } }
        public int Range { get { return range; } }
        public int Durability { get { return durability; } }
        public int Cost { get { return cost; } }

        public string WeaponType { get { return weaponType; } set { weaponType = value; } }

        public Weapon (char symbol, int x = 0, int y = 0) : base (x, y, TileEnum.WEAPON) { this.symbol = symbol; }
    }
}
