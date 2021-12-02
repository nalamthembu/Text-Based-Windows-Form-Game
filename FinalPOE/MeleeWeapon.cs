namespace FinalPOE
{
    public enum Types
    {
        DAGGER, LONGSWORD
    }

    public class MeleeWeapon : Weapon
    {
        public new int Range { get { return 1; } } //overridden accessor.

        //✧ <-- melee symbol. (OLD), 🗡 (U+2020) <-- melee Symbol (NEW)

        //static char mSymbol = '\u2020';

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
                    range = 2;
                    break;
            }
        }
    }
}
