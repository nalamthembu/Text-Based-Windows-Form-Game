using System;

namespace FinalPOE
{
    [Serializable]
    public class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5){}

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NOMOVEMENT)
        {
            return MovementEnum.NOMOVEMENT; //no movement is 0.
        }

        public override bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 2; // the distance at corners is technically 2 blocks away from the mage.
        }
    }
}
