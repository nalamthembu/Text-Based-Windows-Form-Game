using System;

namespace FinalPOE
{
    public class Shop
    {
        Weapon[] weaponsInStock;
        [NonSerialized]
        Random random = new Random();
        char buyerSymbol;
        Character buyer; //might need this, since the qPaper doesn't explain how this class knows who the buyer is.

        public Shop(char buyerSymbol)
        {
            weaponsInStock = new Weapon[3];
            this.buyerSymbol = buyerSymbol;

            for(int i = 0; i < weaponsInStock.Length; i++)
            {
                weaponsInStock[i] = RandomWeapon();
            }
        }

        Weapon RandomWeapon()
        {
            int num = random.Next(0, 4);

            switch(num)
            {
                case 0:
                    return new MeleeWeapon(Types.DAGGER);

                case 1:
                    return new MeleeWeapon(Types.LONGSWORD);

                case 2:
                    return new RangedWeapon(RangedTypes.LONGBOW);

                case 3:
                    return new RangedWeapon(RangedTypes.RIFLE);
            }

            //If we end up here, something went very VERY wrong.
            return null;
        }

        public bool CanBuy(int num)
        {
            return buyer.GoldPurseTotal - weaponsInStock[num].Cost > 0;
        }

        public void Buy(int num)
        {
            buyer.GoldPurseTotal -= weaponsInStock[num].Cost;
            buyer.PickUp(weaponsInStock[num]);
            weaponsInStock[num] = RandomWeapon();
        }

        public string DisplayWeapon(int num) //Triggered by form button.
        {
            return 
                String.Format("Buy {0} ({1} Gold)", 
                weaponsInStock[num].WeaponType,
                weaponsInStock[num].Cost);
        }
    }
}
