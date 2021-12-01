using static FinalPOE.MovementEnum;
using System;

namespace FinalPOE
{
    public class Leader : Enemy
    {
        private Tile target;

        public Tile Target { get { return target; } set { target = value; } }

        public Leader(int x, int y) : base(x, y, 2, 20) { }

        public override MovementEnum ReturnMove(MovementEnum move = NOMOVEMENT)
        {
            /*' A leader will always move towards its target(the Hero).
                If it can not move towards its target because something is
                in the way (based on the vision array), it continuously rolls a random
                direction until it finds a valid direction in which to move.
            */

            int moveDir = 0;

            if (target is Character t)
            {
                if (DistanceTo(t) > 0)
                {
                    /* if something was in the way in every direction, 
                     * theres no need to continue looking for a valid direction 
                     * because every direction is blocked, so you'd be infinitely 
                     * looking for an unblocked path when there is none. so I will 
                     * simply add something to stop it from infinitely looking and 
                     * just limit it to a few tries.
                     */

                    int tries = 0;

                    for(int i = 0; i < vision.Length;i++)
                    {
                        /*If the difference between my X and the targets X is negative,
                         then the absolute number of the difference is how many spaces to the right 
                        I am away from the target*/
                        if (target.X == vision[i].X && this.X - target.X < 0)
                        {
                            //Therefore I should move to the right.
                            return RIGHT;
                        }
                        /*If the difference between my X and the targets X is positive,
                         the difference is how many spaces to the left I am away from the target*/
                        else if (target.X == vision[i].X && this.X - target.X > 0)
                        {
                            //Therefore I should move to the left.
                            return LEFT;
                        }
                        
                        //Same for up and down.

                        if (target.Y == vision[i].Y && this.Y - target.Y < 0)
                        {
                            return UP;
                        }

                        if (target.Y == vision[i].Y && this.Y - target.Y > 0)
                        {
                            return DOWN;
                        }
                    }

                    do
                    {
                        moveDir = random.Next(0, 4);
                        tries--;
                        if (tries == 0)
                        {
                            return NOMOVEMENT;
                        }
                    }
                    while (!(vision[moveDir] is EmptyTile));
                }
            }

            return (MovementEnum) moveDir;
        }
    }
}
