using System;

namespace FinalPOE
{
    [Serializable]
    public enum MovementEnum
    {
        UP, RIGHT, DOWN, LEFT, NOMOVEMENT
    }

    [Serializable]
    public abstract class Character : Tile
    {
        protected int hp, maxHp, damage, goldPurseTotal;
        public int HP { 
            get { return hp; } 
            set { hp = (hp < 0) ? 0 : value;} 
        }

        public int GoldPurseTotal
        {
            get { return goldPurseTotal; }
            set { goldPurseTotal = value; }
        }

        public int MaxHP { get { return maxHp; } }
        public int Damage { get { return damage; } }

        protected Tile[] vision = new Tile[4];
        public Tile[] Vision { get { return vision;} }

        protected Weapon weapon;

        public Weapon Weapon { get { return weapon; } set { weapon = value; } }

        public Character(int x, int y, TileEnum tileType) : base(x, y, tileType) { }

        public virtual void Attack(Character target) { target.HP -= damage; }
        public bool IsDead() { return hp <= 0; }
        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 1;
        }

        protected int DistanceTo(Character target)
        {
            int xDist = Math.Abs(target.X - x);
            int yDist = Math.Abs(target.Y - y);
            return xDist + yDist;
        }

        public void Move(MovementEnum move)
        {
            switch(move)
            {
                case MovementEnum.LEFT:
                    x--;
                    break;
                case MovementEnum.RIGHT:
                    x++;
                    break;
                case MovementEnum.UP:
                     y--; //Strangely enough, this has to be negative
                    break;
                case MovementEnum.DOWN:
                    y++; //AND, this has to be positive, what a world we live in.
                    break;
            }
        }

        public void UpdateVision(Map map)
        {
            vision[0] = map.GetTileAt(x, y - 1);
            vision[1] = map.GetTileAt(x + 1, y);
            vision[2] = map.GetTileAt(x, y + 1);
            vision[3] = map.GetTileAt(x - 1, y);
        }

        public void PickUp(Item i)
        {
            if (i is Gold g)
            {
                goldPurseTotal += g.GoldAmount;
                System.Diagnostics.Debug.WriteLine("Found Gold + {0}GOLD!", g.GoldAmount);
            }
            else if (i is Weapon w)
            {
                Equip(w);
            }
        }

        private void Equip(Weapon w)
        {
            weapon = w;
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = MovementEnum.NOMOVEMENT);
        public abstract override string ToString();
    }
}
