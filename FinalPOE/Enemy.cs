using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    public abstract class Enemy : Character
    {
        [NonSerialized]
        protected static Random random = new Random();
       

        public Enemy(int x, int y, int damage, int maxHp) : base(x, y, TileEnum.ENEMY)
        {
            this.damage = damage;
            this.maxHp = maxHp;
            hp = this.maxHp;
        }

        public override string ToString()
        {
            if (isBeingLooted)
            {
                string textToReturn =
                    (weapon is not null) ? String.Format("\n{0} Was Looted\n{0} : -{1}\n{0} : -1{2} Gold\n{3}: +{1}\n{3} : +{2} Gold", GetType().Name, weapon.WeaponType, goldPurseTotal, "Player")
                    : String.Format("\n{0} Was Looted\n{0} : -1{1} Gold\n{2} : +{1} Gold", GetType().Name, goldPurseTotal, "Player");

                isBeingLooted = false;
                return textToReturn;
            }

            if (this is Goblin)
            {
                return string.Format("Equipped:" + GetType().Name +
                 "({0}/{1}HP) at [{2},{3}] with {4}\n({5}X{6})",
                 hp, maxHp, x, y, weapon.WeaponType, weapon.Durability, weapon.Damage);
            }

            return string.Format(GetType().Name + " at [{0},{1}] ({2})", x,y, damage);
        }
    }
}
