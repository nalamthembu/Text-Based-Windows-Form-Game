using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPOE
{
    [Serializable]
    public abstract class Enemy : Character
    {
        [NonSerialized]
        protected Random random = new Random();

        public Enemy(int x, int y, int damage, int maxHp) : base(x, y, TileEnum.ENEMY)
        {
            this.damage = damage;
            this.maxHp = maxHp;
            hp = this.maxHp;
        }

        public override string ToString()
        {
            return string.Format(GetType().Name + " at [{0},{1}] ({2})", x,y, damage);
        }
    }
}
