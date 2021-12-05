using System;
using System.Collections.Generic;
using System.Text;

//To-Do : This class might need work, just putting this here so we know to check here if anything breaks.

namespace FinalPOE
{
    [Serializable]
    public class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x,y, 3, 10) 
        {
            weapon = new MeleeWeapon(Types.DAGGER); //spawns in with a dagger.

            goldPurseTotal = 1;
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
            while (!(vision[moveDir] is EmptyTile or Item)); //Need to figure out why adding an item check here stops the goblins from moving.

            return (MovementEnum) moveDir;
        }
    }
}
