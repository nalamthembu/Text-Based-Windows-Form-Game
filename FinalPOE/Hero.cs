using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    public class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(x, y, TileEnum.HERO)
        {
            damage = 2;
            maxHp = 10;
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
            return string.Format("Player Stats:\nHP: {0}/{1}\nCurrent Weapon : {6}\nDamage: {2}\nWeapon Range: {7}\nWeapon Damage: {8}\nGold: {3}G\n[{4},{5}]", hp, maxHp, damage, GoldPurseTotal,x, y, weaponString, (weapon != null) ? weapon.Range : "1", (weapon != null) ? weapon.Damage : damage);
        }
    }
}
