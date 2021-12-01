using System;
using System.Collections.Generic;
using System.Text;

//To-Do : This class might need work, just putting this here so we know to check here if anything breaks.

namespace FinalPOE
{
    [Serializable]
    public class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x,y, 10, 10) 
        {
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            int moveDir;
            int tries = 10;

            do
            {
                moveDir = random.Next(0, 4);
                tries--;
                if (tries == 0)
                {
                    return MovementEnum.NOMOVEMENT;
                }
            }
            while (!(vision[moveDir] is EmptyTile) || !(vision[moveDir] is EmptyTile));

            return (MovementEnum) moveDir;
        }
    }
}
