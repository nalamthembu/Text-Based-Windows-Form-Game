using System;

namespace FinalPOE
{
    //Long range weapon symbol - ✦ (OLD), 🔫 <- NEW (U+1F52B) -- didn't work.

    [Serializable]
    public class RangedWeapon : Weapon
    {
        public new int Range { get { return base.range; } }

        public RangedWeapon(Types rangedTypes, int x = 0, int y = 0) : base('✦', x, y)
        {
            switch(rangedTypes)
            {
                case Types.RIFLE:
                    weaponType = "Rifle";
                    durability = 3;
                    range = 3;
                    damage = 5;
                    cost = 7;
                    break;

                case Types.LONGBOW:
                    weaponType = "Longbow";
                    durability = 4;
                    range = 2;
                    damage = 4;
                    cost = 6;
                    break;
            }
        }

        /*Another constructor may be needed when loading Weapons equipped to
        Characters from a file. This receives both a type variable and an integer
        denoting durability of the weapon (as it may have been used).*/

        public RangedWeapon(Types rangedTypes, int durability) : base('✦', 0, 0)
        {
            //Don't know yet, but will probably be used for loading.
            switch (rangedTypes)
            {
                case Types.RIFLE:
                    this.durability = durability; //could be changed later, we'll see.
                    range = 3;
                    damage = 5;
                    cost = 7;
                    break;

                case Types.LONGBOW:
                    this.durability = durability; //could be changed later, we'll see.
                    range = 2;
                    damage = 4;
                    cost = 6;
                    break;
            }
        }
    }
}
