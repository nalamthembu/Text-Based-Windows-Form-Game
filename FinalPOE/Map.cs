using System;

namespace FinalPOE
{
    [Serializable]
    public class Map
    {
        public Tile[,] mapTileArray;
        Hero hero;
        public Enemy[] enemyArray;
        
        public int mapWidth, mapHeight;

        public Hero Hero { get { return hero; } }
        public Tile[,] map { get { return mapTileArray; } set { mapTileArray = value; } }

        public Item[] itemArray;

        public Enemy[] EnemyArray { get { return enemyArray; } }
        

        [NonSerialized]
        readonly Random r = new Random();

        public Map(int minHeight, int minWidth, int maxHeight, int maxWidth, int enemyCount, int goldCount, int weapCount)
        {
            mapWidth = r.Next(minWidth, maxWidth + 1);
            mapHeight = r.Next(minHeight, maxHeight + 1);

            mapTileArray = new Tile[mapWidth, mapHeight];

            CreateMap();

            enemyArray = new Enemy[enemyCount];

            hero = (Hero)Create(TileEnum.HERO);
            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i] = (Enemy)Create(TileEnum.ENEMY);
            }

            itemArray = new Item[goldCount + weapCount]; //with weapons.
            for (int i = 0; i < goldCount; i++)
            {
                itemArray[i] = (Gold)Create(TileEnum.GOLD);
            }

            for(int i = goldCount; i < goldCount + weapCount; i++)
            {
                itemArray[i] = (Weapon)Create(TileEnum.WEAPON);
            }

            UpdateVision();

           // PopulateMap_Alternate();
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x < 0 || x > mapWidth || y < 0 || y > mapHeight)
            {
                return null;
            }

            return map[x, y];
        }

        public void SetEmptyTile(int x, int y)
        {
            if (x < 0 || x > mapWidth || y < 0 || y > mapHeight)
            {
                return;
            }

            map[x, y] = new EmptyTile(x, y);
        }

        public void UpdateVision()
        {
            CreateMap();

            hero.UpdateVision(this);

            for (int i = 0; i < enemyArray.Length; i++)
            {
                enemyArray[i].UpdateVision(this);
            }
        }

        private void CreateMap()
        {
            Tile[,] m = mapTileArray;

            for (int y = 0; y <= mapHeight - 1; y++)
            {
                for (int x = 0; x <= mapWidth - 1; x++)
                {
                    if (x == 0 || x == mapWidth - 1 || y == 0 || y == mapHeight - 1)
                    {
                        m[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        m[x, y] = new EmptyTile(x, y);
                    }
                }
            }

            if (hero != null)
            {
                m[hero.X, hero.Y] = hero;
            }

            if (enemyArray != null)
            {
                foreach (Enemy e in enemyArray)
                {
                    if (e != null)
                    {
                        m[e.X, e.Y] = e;
                    }
                }
            }

            if (itemArray != null)
            {
                foreach (Item i in itemArray)
                {
                    if (i != null)
                    {
                        m[i.X, i.Y] = i;
                    }
                }
            }

            mapTileArray = m;
        }

        private Tile Create(TileEnum type)
        {
            int x, y;
            Tile newTile = null;

            do
            {
                x = r.Next(1, mapWidth); //Changed this to 1 because 0 is the outer edge 
                y = r.Next(1, mapHeight);//Changed this to 1 because 0 is the outer edge 
            }
            while (!(mapTileArray[x, y] is EmptyTile));

            switch (type)
            {
                case TileEnum.ENEMY:
                    //Randomly chooses between 0 and 10 ---> [anything more than 8 = goblin], 0 - 5 = Mage.
                    if (r.Next(0, 11) <= 5)
                    {
                        newTile = new Goblin(x, y);
                    }
                    else
                    {
                        if (r.Next(0, 2) == 1)
                        {
                            newTile = new Mage(x, y);
                        }
                        else
                        {
                            newTile = new Leader(x, y); //the hero would have been created by now.

                            Leader l = (Leader)newTile;
                            l.Target = hero; //setting the hero as the target.
                            newTile = l; //reassigningg the newTile.
                        }
                    }

                    break;
                case TileEnum.HERO:
                    newTile = new Hero(x, y, 20);
                    break;

                case TileEnum.GOLD:
                    newTile = new Gold(x, y);
                    /*Gold amount is set between 1 and 5 in 
                     * the Gold class constructor anyway so theres 
                     * no need to repeat that process here
                     */
                    break;

                case TileEnum.WEAPON:
                    if (r.Next(0, 10) <= 5) //50% chance of spawning a melee weapon.
                    {
                        if (r.Next(0, 2) == 1)//50% chance of spawning a dagger.
                        {
                            newTile = new MeleeWeapon(Types.DAGGER, x, y);
                        }
                        else newTile = new MeleeWeapon(Types.LONGSWORD, x, y);
                    }
                    else
                    {
                        if (r.Next(0, 2) == 1)//50% chance of spawning a longbow.
                        {
                            newTile = new RangedWeapon(RangedTypes.LONGBOW, x, y);
                        }
                        else newTile = new RangedWeapon(RangedTypes.RIFLE, x, y);
                    }
                    break;
            }

            mapTileArray[x, y] = newTile;

            return newTile;
        }

        public Item GetItemAtPosition(int x, int y)
        {
            for (int i = 0; i < itemArray.Length; i++)
            {
                if (itemArray[i] != null)
                {
                    if (itemArray[i].X == x && itemArray[i].Y == y)
                    {
                        Item itemToReturn = itemArray[i];

                        itemArray[i] = null;

                        return itemToReturn;
                    }
                }
            }

            return null;
        }


        public override string ToString()
        {
            string value = "";

            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if (x == hero.X && y == hero.Y)
                    {
                        value += 'H';
                        continue;
                    }

                    if (map[x, y] is EmptyTile)
                    {
                        value += '.';
                    }
                    else if (map[x, y] is Obstacle)
                    {
                        value += 'O';
                    }
                    else if (map[x, y] is Enemy enemy)
                    {
                        if (enemy.IsDead())
                        {
                            value += "x";
                        }
                        else if (enemy is Goblin)
                        {
                            value += 'G';
                        }
                        else if (enemy is Mage)
                        {
                            value += "M";
                        }
                        else if (enemy is Leader)
                        {
                            value += "L";
                        }
                    }
                    else if (map[x, y] is Item item)
                    {
                        if (item is Gold)
                        {
                            value += "$";
                        }

                        if (item is Weapon weapon)
                        {
                            value += weapon.symbol;
                        }
                    }
                }
                value += "\n";
            }

            return value;
        }
    }
}