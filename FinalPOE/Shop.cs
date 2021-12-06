using System;

namespace FinalPOE
{
    [Serializable]
    public class Shop
    {
        Weapon[] weaponsInStock;
        [NonSerialized]
        Random random = new Random();
        char buyerSymbol;
        Character buyer; //might need this, since the qPaper doesn't explain how this class knows who the buyer is.

        public Shop(Character buyer)
        {
            weaponsInStock = new Weapon[3];
            

            for(int i = 0; i < weaponsInStock.Length; i++)
            {
                weaponsInStock[i] = RandomWeapon(); //Weapon array initialised to three randomised weapons
            }

            this.buyer = buyer;
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
                    return new RangedWeapon(Types.LONGBOW);

                case 3:
                    return new RangedWeapon(Types.RIFLE);
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

        public string DisplayWeapon(int num) //Display weapon formats a weapon string to be shown on Form.
        {
            return 
                String.Format("Buy {0} ({1} Gold)", 
                weaponsInStock[num].WeaponType,
                weaponsInStock[num].Cost);
        }
    }
}
