using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPOE
{
    public enum Types
    {
        DAGGER, LONGSWORD
    }

    public class MeleeWeapon : Weapon
    {
        public new int Range { get { return 1; } } //overridden accessor.

        //✧ <-- melee symbol.

        public MeleeWeapon(Types meleeType, int x = 0, int y = 0) : base('✧', x, y)
        {
            switch(meleeType)
            {
                case Types.DAGGER:
                    weaponType = "Dagger";
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    break;

                case Types.LONGSWORD:
                    weaponType = "Longsword";
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    break;
            }
        }
    }
}
