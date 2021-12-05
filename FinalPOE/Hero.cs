using System;
using System.Diagnostics;

namespace FinalPOE
{
    [Serializable]
    public class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(x, y, TileEnum.HERO)
        {
            damage = 2;
            maxHp = 100;
            this.hp = hp;
            maxHp = hp;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NOMOVEMENT)
        {
            if (move == MovementEnum.NOMOVEMENT)
            {
                return move;
            }

            Tile selectedTile = Vision[(int)move];

            if (selectedTile is EmptyTile || selectedTile is Item)
            {
                return move;
            }
            else
            {
                return MovementEnum.NOMOVEMENT;
            }
        }

        public override string ToString()
        {
            string weaponString = (weapon is null) ? "Barehands" : weapon.WeaponType;
            string withWeapon = "Player Stats:\nHP: {0}/{1}\nCurrent Weapon : {2}\nWeapon Range: {3}\nWeapon Damage: {4}\nGold: {5}G\n[{6},{7}]";
            string withOutWeapon = "Player Stats:\nHP: {0}/{1}\nCurrent Weapon : {3}\nDamage: {4}\nGold: {3}G\n[{5},{6}]";

            if (weapon is not null) Debug.WriteLine(weapon.WeaponType);


            if (weapon is null)
            {
                return string.Format(withOutWeapon, hp, maxHp, weaponString, damage, goldPurseTotal, x, y);
            }
            else
            return string.Format(withWeapon, hp, maxHp, weaponString, damage, weapon.Range, weapon.Damage, goldPurseTotal, x, y);
        }
    }
}
