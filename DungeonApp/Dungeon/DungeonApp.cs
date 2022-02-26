using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using EnemyLibrary;


namespace DungeonApplication
{
    class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.Title = "Star Wars";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Star Wars Application");
            #region Music
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
           Console.Beep(440,1000);
            #endregion
            Console.WriteLine("\n\nPlease press Enter to continue");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("\n\nPlease enter your name: ");
            string playerName = Console.ReadLine();
            int score = 0;
            Weapon weapon = new Weapon(1, 80, "lightsaber", 50, false);

            bool exit = false;

            do//room 1
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nPlease enter your character Race:\n" +
                        "Trandoshan: T\n" +
                        "Mandalorian: M\n" +
                        "Human: H\n" +
                        "Geonosian: G\n" +
                        "Mon Calamari: C\n" +
                        "Gungan: N\n" +
                        "Wookie: W\n" +
                        "Talz: L\n" +
                        "Quarren: Q\n" +
                        "Muun: U\n" +
                        "Bith: B\n" +
                        "Lasat: A\n" +
                        "Togruta: R\n" +
                        "Zabrak: Z\n");
                ConsoleKey playerRace = Console.ReadKey(true).Key;
                Console.Clear();                
                Player player = new Player(playerName, 100, 0, 100, 100, playerRace, weapon);

                bool reload = false;

                //Creating Enemy
                Rancor r = new Rancor("Rancor", 150, 150, 1, 0, 1, 80, "A Rancor; a towering hulk of muscle born to kill from the planet Dathomir blocks your path."); 

                StormTrooper s = new StormTrooper("Stormtrooper", 66, 40, 20, 20, 1, 20, "A Stormtrooper enters the room. An elite shock trooper bound with fanatic dedication to the Empire, he looks dangerous...");

                TuskenRaider t1 = new TuskenRaider("Tusken Raider", 75, 110, 20, 20, 1, 20, "A Tusken Raider, indigenous to the planet Tatooine; wearing abundant clothing to protect themselves from the harsh weather and holding a slugthrower enters.They look insane.");

                CloneTrooper66 c = new CloneTrooper66("Clone Trooper", 75, 75, 1, 20, 1, 66, "A Clone Trooper enters the room. Cloned and bred for war, Order 66 is enacted. He's not here to be friendly.");

                Enemy[] enemies = { r, r, s, s, t1, c, c, c };

                Random rand = new Random();

                int randomNbr = rand.Next(enemies.Length);

                Enemy enemy = enemies[randomNbr];

                Console.WriteLine("\n  " + enemy.Description);

                do
                {

                    #region GAME
                    Console.WriteLine(GetRoom());
                    Console.Write("\nWhat Do You Do??\n" +
                        "A) Fight\n" +
                        "R) Coward's Way\n" +
                        "P) Player Info\n" +
                        "M) Enemy Info\n" +
                        "I) Inventory\n" +
                        "x) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        //Attack
                        case ConsoleKey.A:
                            Combat.DoBattle(player, enemy);
                            if (enemy.Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", enemy.Name);
                                Console.ResetColor();
                                reload = true;
                                score++;
                            }
                            break;

                        case ConsoleKey.R:

                            Console.WriteLine("Coward!!");
                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine("Player Info");
                            
                            Console.WriteLine(player);
                            Console.WriteLine("Enemies vanquished: " +score);

                            break;

                        case ConsoleKey.M:

                            Console.WriteLine("Enemy Info");
                            Console.WriteLine(enemy);

                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.WriteLine("You fade into nothingness...");

                            exit = true;

                            break;


                        default:

                            Console.WriteLine("Your fat fingers put in the wrong input. Do it again.");

                            break;
                    }

                    #endregion

                    

                    if (player.Health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU ARE DEAD");
                        Console.Beep(80, 300);
                        exit = true;
                    }


                } while (!reload && !exit);


            } while (!exit);//WHile exit is NOT TRUE, keep loop


            //Output the player's final score
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s. You could have done better if you didn't die."));
        }//End Main


        //Creat GetRoom() & plug it into the TODO above
        private static string GetRoom()
        {
            string[] rooms =
            {
                "You are sitting in a room very reminisce of the room from which you previously sat in, only there's a catch. It is pitch black. You feel the presence of other living things around you, although you don't recognize the strange aura surrounding these creatures. You feel uncomfortable and you feel as if these creatures aren't here to be your friend.",
                 "This room holds six dry circular basins large enough to hold a man and a dry fountain at its center. All possess chipped carvings of merfolk and other sea creatures. It looks like this room once served some group of people as a bath.",
                 "When looking into this chamber, you're confronted by a thousand reflections of yourself looking back. Mirrored walls set at different angles fill the room. A path seems to wind through the mirrors, although you can't tell where it leads.",
                 "Fire crackles and pops in a small cooking fire set in the center of the room. The smoke from a burning rat on a spit curls up through a hole in the ceiling. Around the fire lie several fur blankets and a bag. It looks like someone camped here until not long ago, but then left in a hurry.",
                 "You pull open the door and hear the scrape of its opening echo throughout what must be a massive room. Peering inside, you see a vast cavern. Stalactites drip down from the ceiling in sharp points while flowstone makes strange shapes on the floor.",
                  "A chill crawls up your spine and out over your skin as you look upon this room. The carvings on the wall are magnificent, a symphony in stonework -- but given the themes represented, it might be better described as a requiem. Scenes of death, both violent and peaceful, appear on every wall framed by grinning skeletons and ghoulish forms in ragged cloaks.",
                  "The scent of earthy decay assaults your nose upon peering through the open door to this room. Smashed bookcases and their sundered contents litter the floor. Paper rots in mold-spotted heaps, and shattered wood grows white fungus."
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }
    }
    }

