using static FinalPOE.MovementEnum;
using System;

namespace FinalPOE
{
    [Serializable]
    public class Leader : Enemy
    {
        private Tile target;

        public Tile Target { get { return target; } set { target = value; } }

        public Leader(int x, int y) : base(x, y, 2, 20) { }

        public override MovementEnum ReturnMove(MovementEnum move = NOMOVEMENT)
        {
            MovementEnum moveDir = NOMOVEMENT;

            int tries = 10;
            int i = 0;

            System.Diagnostics.Debug.WriteLine("L - ({0},{1}), TARGET - ({2},{3})", X, Y, target.X, target.Y);

            if (vision[(int)move - 1] is EmptyTile || vision[(int)move - 1] is Item)
            {
                if (move is UP)
                {
                    return DOWN;
                }
                else if (move is DOWN)
                {
                    return UP;
                }

                if (move is RIGHT)
                {
                    return LEFT;
                }

                if (move is LEFT)
                {
                    return RIGHT;
                }
            }

            do
            {
                i = random.Next(0, 4);

                if (tries == 0)
                    break;

                tries--;
            }
            while (vision[i] is not EmptyTile || vision[i] is not Item);

            if (vision[i] is EmptyTile || vision[i] is Item)
            {
                moveDir = (MovementEnum)i;
            }

            return moveDir;
        }
    }
}
