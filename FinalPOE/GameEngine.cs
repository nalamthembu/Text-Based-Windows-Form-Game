using System;
using static FinalPOE.MovementEnum;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace FinalPOE
{
    public class GameEngine
    {
        private Map map;
        public Map Map { get { return map; } }

        private Shop shop; //needs to be initialised.

        public Shop Shop { get { return shop; } }

        public GameEngine(int minH, int minW, int MaxH, int MaxW, int numEnemy, int numGold, int numWeapon)
        {
            map = new Map(minH, minW, MaxH, MaxW,numEnemy, numGold, numWeapon);
            shop = new Shop(map.Hero);
        }

        public GameEngine()
        {
        }


        public string enemyAttackIndicator = "";


        public bool Move(MovementEnum move)
        {
            enemyAttackIndicator = "";

            Hero h = map.Hero;

            if (map.Hero.ReturnMove(move) == NOMOVEMENT)
                return false;

            int oldX = h.X;
            int oldY = h.Y;

            h.Move(move);

            //System.Diagnostics.Debug.WriteLine("("+h.X + "," + h.Y + ")");


            Item possibleItem = map.GetItemAtPosition(h.X,h.Y); 
            
            if (possibleItem != null)
            {
                h.PickUp(possibleItem);
            }

            map.SetEmptyTile(oldX, oldY);

            map.UpdateVision();

            MoveEnemies(move);
            //Character vision is updated in Map.UpdateVision()
            
            return true;
        }

        public void MoveEnemies(MovementEnum playersMovement)
        {
            foreach(Enemy e in map.enemyArray)
            {
                if (!(e is Mage) && !e.IsDead()) //If its not a mage and is not dead, move.
                {
                    if (!(e is Leader))
                    {
                        e.ReturnMove(playersMovement);
                    }

                    MovementEnum movDir = e.ReturnMove();
                    
                    e.Move(movDir);

                    Item possibleItem = map.GetItemAtPosition(e.X, e.Y);

                    if (possibleItem != null)
                    {
                        e.PickUp(possibleItem);

                        Debug.WriteLine(e.GetType().Name + " has picked up a " + possibleItem.GetType().Name);
                    }

                    map.UpdateVision();
                }

                EnemyAttacks();
            }
        }

        public void EnemyAttacks()
        {
            foreach (Enemy e in map.EnemyArray)
            {
                if (!e.IsDead())
                {
                    if (e is Mage m)
                    {
                        Tile[] potentialTargets = new Tile[]
                            {
                            map.GetTileAt(m.X - 1, m.Y + 1),//top left
                            map.GetTileAt(m.X + 0, m.Y + 1),//top mid
                            map.GetTileAt(m.X + 1, m.Y+ 1),//top right
                            map.GetTileAt(m.X - 1, m.Y + 0),//left
                            map.GetTileAt(m.X + 1, m.Y + 0),//right
                            map.GetTileAt(m.X- 1, m.Y - 1),//bottom left
                            map.GetTileAt(m.X + 0, m.Y -1),//bottom mid
                            map.GetTileAt(m.X + 1, m.Y - 1),//bottom right.
                            };

                        for (int i = 0; i < potentialTargets.Length; i++)
                        {
                            if (potentialTargets[i] is Character c)
                            {
                                if (m.CheckRange(c))
                                {
                                    if (!c.IsDead())
                                    {
                                        m.Attack(c);
                                    }

                                    if (c is Hero)
                                        enemyAttackIndicator = "\nPlayer was attacked by Mage!";

                                    if (c is Enemy)
                                        System.Diagnostics.Debug.WriteLine("Enemy attacked by Mage");
                                    map.UpdateVision();
                                }
                            }
                        }
                    }

                    else
                    {
                        for (int i = 0; i < e.Vision.Length; i++)
                        {
                            if (e.Vision[i] is Character c)
                            {
                                if (!(e.Vision[i] is Enemy))
                                {
                                    if (!e.IsDead())
                                    {
                                        e.Attack(c);
                                    }

                                    if (c is Hero)
                                        enemyAttackIndicator = "\nPlayer was attacked by Goblin!";
                                    
                                    map.UpdateVision();
                                    break;
                                }
                            }
                        }
                    }
                }

                
            }

            map.UpdateVision();
            
        }

        public Character PlayerAttack(MovementEnum dir)
        {
            Hero h = map.Hero;

            int visionIndex = (int)dir;
            
            if (h.Vision[visionIndex] is Character c)
            {
                if (!c.IsDead())
                {
                    map.Hero.Attack(c);

                    if (c.IsDead())
                    {
                        c.isBeingLooted = true;
                        map.Hero.Loot(c);
                        Debug.WriteLine(c.GetType().Name + " was looted.");
                    }
                }

                return c;
            }
            

            EnemyAttacks();

            return null;
        }

        const string SAVEDATA = "save_game.sgf";

        FileMode mode = File.Exists(SAVEDATA) ? FileMode.Append : FileMode.Create;

        public void Save()
        {
            FileStream stream = new FileStream(SAVEDATA, mode, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, map);

            stream.Close();

            System.Diagnostics.Debug.WriteLine("Saved Successfully");
        }

        public void Load()
        {
            FileStream stream = new FileStream(SAVEDATA, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            while (stream.Position < stream.Length)
            {
                map = (Map)bf.Deserialize(stream);
            }

            stream.Close();

            if (shop is null)
            {
                shop = new Shop(map.Hero);
            }

            System.Diagnostics.Debug.WriteLine("Loaded Successfully");
        }
    }
}
