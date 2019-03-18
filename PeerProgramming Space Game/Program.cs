using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
 
    

    class Program
    {
        private static object textBox;

        static void Main(string[] args)
        {

            Planet planet = new Planet();
            //planet.NewPlanet();
            Atom atom = new Atom();
            //atom.AtomsStats();

            // Planet planet = new Planet();
            //  planet.NewPlanet();
            // Atom atom = new Atom();
            // atom.AtomsStats();
          

            gameStartStory();

         

            Console.ReadLine();
            atom.weapons += 2;

            
            atom.money += 10;

            

            //Console.WriteLine(atom.money);
            // Potentially add in menu to go to different planets
            //AtomsStats(+100, +2, "Arcadia", +2, true);

            Console.ReadLine();
         
            // travelMenu();

            PlanetList();

            Console.ReadLine();

        }

        private static void PlanetList()
        {
            Atom atom = new Atom();
            Planet planet = new Planet();
            Random random = new Random();

           

            // random.Next(0, 3);
            int myRandom = random.Next(0, 10);

            if (myRandom == 1)
            {
                planet.IsProsperous = false;
            }
            else
            {
                planet.IsProsperous = true;
            }

           
            List<Planet> galaxy = new List<Planet>();
            galaxy.Add(new Planet(1, 1, "Earth", planet.IsProsperous));
            galaxy.Add(new Planet(.05, 2, "Pluto", planet.IsProsperous));
            galaxy.Add(new Planet(2, 2.5, "Waconda", planet.IsProsperous));

            void CenteredString(string s)
            {
                if (s.Length <= Console.WindowWidth)
                {
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(s);
                }
                else
                {
                    throw new Exception("Oversided String");
                }
            }

            CenteredString("What planet do you want to go to?");
            CenteredString("1. Earth");
            CenteredString("2. Pluto");
            CenteredString("3. Waconda");


            int travel = int.Parse(Console.ReadLine());
            travel -= 1;
            galaxy.ToArray();
            CenteredString(galaxy[travel].Name); 

            
            


            //if (galaxy[0].IsProsperous)
            //{
            //    // atom.money += myRandom;
            //    Console.WriteLine("You did make money");
            //    Console.WriteLine(planet.IsProsperous);
            //}
            //else
            //{
            //    // atom.money = atom.money - myRandom;
            //    Console.WriteLine("you didnt make money");
            //    Console.WriteLine(planet.IsProsperous);
            //}
        }
        public static void AtomsStats(double money, int weapons, string spaceship, int ammo, bool isAlive)
        {
           
            Atom atom = new Atom();

            atom.money = 0;
            atom.weapons = 0;
            atom.spaceship = "";
            atom.ammo = 0;
            atom.isAlive = true;

            Console.WriteLine(atom.money);
        }
        public static void AtomsStats() //overloaded method????
        {
            Atom atom = new Atom();
            atom.money = 0;
            atom.weapons = 0;
            atom.spaceship = "";
            atom.ammo = 0;
            atom.isAlive = true;
            Console.WriteLine(atom.money);
        }

        private static void gameStartStory()
        {
            Atom atom = new Atom();
            Console.ForegroundColor = ConsoleColor.Green;

            void CenteredString(string s)
            {
                if (s.Length <= Console.WindowWidth)
                {
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(s);
                }
                else
                {
                    throw new Exception("Oversided String");
                }
            }

            CenteredString(@" _________                           ___________                   ___            ");
            CenteredString(@"/   _____/__________    ____  ____   \__    ___/___________     __| _/___________ ");
            CenteredString(@" \_____  \\____ \__  \ _/ ___\/ __ \    |    |  \_  __ \__  \   / __ |/ __ \_  __ \");
            CenteredString(@" /        \  |_> > __ \\  \__\  ___/    |    |   |  | \// __ \_/ /_/ \  ___/|  | \/");
            CenteredString(@"/_______  /   __(____  /\___  >___  >   |____|   |__|  (____  /\____ |\___  >__|   ");
            CenteredString(@"        \/|__|       \/     \/    \/                        \/      \/    \/       ");

            Console.WriteLine("\n");


           


            CenteredString("A human by the name of Atom from");
            CenteredString("the galaxy: Milky Way, was on a mission");
            CenteredString("to be the richest man in the universe");
            CenteredString("and to achieve world dominance. He wasn't");
            CenteredString("the only one with this goal. His arch nemesis");
            CenteredString("Molecule, from the galaxy of Lilypad, had the same idea.");
            CenteredString("In order to achieve his goal, Atom decided to construct");
            CenteredString("a spaceship called Arcadia, and set off from planet Earth");
            CenteredString("in Arcadia, to space, in order to trade atomic weapons");
            CenteredString("and ammo to other life forms on different planets for money and goods,");
            CenteredString("in order to destroy Molecule and achieve his overall goal");
            CenteredString("of world dominance.\n\n\n");



            CenteredString("Press any key to advance...");
            Console.ReadLine();

            CenteredString($"  You have ${atom.money}.00");
            CenteredString($"  You have {atom.weapons} weapons");
            //AtomsStats(atom.money += 10);
            //atom.weapons += 2; 
            //atom.spaceship += "Arcadia"; 
            //atom.ammo += 1;

            //AtomsStats();


        }

        private static void WarehouseMenu()
        {
            
            //Console.Clear();
           
            Console.Write("\n\n 1) MONEY\n 2) WEAPONS\n 3) Fuel\n 4) SELL WEAPONS\n 5) SELL FUEL\n\n  ");
            //int caseSwitch = 1;
            int menuOption = int.Parse(Console.ReadLine());
            try
            {

            
       
                switch (menuOption)
                {
                        case 1:
                            Console.WriteLine("\n MONEY");
                            break;
                        case 2:
                            Console.WriteLine("\n BUY WEAPONS");
                            break;
                        case 3:
                            Console.WriteLine("\n BUY FUEL");
                            break;
                        case 4:
                            Console.WriteLine("\n SELL WEAPONS" );
                            break;
                        case 5:
                            Console.WriteLine("\n SELL FUEL");
                            break;
                        default:
                            Console.WriteLine("\n Leave Menu");
                            break;
                }
            }

                 catch (Exception)
            {

                WarehouseMenu();
            }
        }







    }

}
    

    
