using static FinalPOE.MovementEnum;
using System;

namespace FinalPOE
{
    [Serializable]
    public class Leader : Enemy
    {
        private Tile target;

        public Tile Target { get { return target; } set { target = value; } }

        public Leader(int x, int y) : base(x, y, 2, 20) //Leader stats (damage and HP)
        {
            weapon = new MeleeWeapon(Types.LONGSWORD);
            goldPurseTotal = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move = NOMOVEMENT)
        {
            MovementEnum moveDir = NOMOVEMENT;

            int tries = 10;
            int i;

            //System.Diagnostics.Debug.WriteLine("L - ({0},{1}), TARGET - ({2},{3})", X, Y, target.X, target.Y);

            //MoveTowards
            if (vision[(int)move - 1] is EmptyTile || vision[(int)move - 1] is Item)
            {
                if (move is UP && y - Target.Y > 0 || move is DOWN && y - Target.Y > 0)
                {
                    return UP;
                }

                if (move is UP && y - Target.Y < 0 || move is DOWN && y - Target.Y < 0)
                {
                    return DOWN;
                }

                if (move is RIGHT && x - Target.X > 0 || move is LEFT && x - Target.X < 0)
                {
                    return RIGHT;
                }

                if (move is LEFT && y - Target.Y < 0 || move is RIGHT && y - Target.Y < 0)
                {
                    return LEFT;
                }

                if (move is RIGHT && x - Target.X == 0 || move is LEFT && x - Target.X == 0)
                {
                    return NOMOVEMENT;
                }
            }
            //End of MoveTowards

            //Randomise if all else fails.
            do
            {
                i = random.Next(0, 4);

                if (tries == 0)
                    break;//In-case Leader is completely blocked off we don't want them continuing to look.

                tries--;
            }
            while (vision[i] is not EmptyTile || vision[i] is not Item);

            if (vision[i] is EmptyTile || vision[i] is Item)
            {
                moveDir = (MovementEnum)i;
            }

            return moveDir;
        }

        public override string ToString()
        {
            if (isBeingLooted)
            {
                return base.ToString();
            }

            return string.Format("Equipped:" + GetType().Name + 
                "({0}/{1}HP) at [{2},{3}] with {4}\n({5}X{6})",
                hp, maxHp, x,y, weapon.WeaponType, weapon.Durability, weapon.Damage);
        }
    }
}
