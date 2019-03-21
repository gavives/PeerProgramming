using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class Planet
    {
        private readonly List<Planet> galaxy;
        private Planet currentPlanet;

        public int    Age          { get; set; } = 25;
        public double Money        { get; set; } 
        public string Name         { get; set; }
        public bool   IsProsperous { get; set; }

        public Planet()
        {
            galaxy = NewPlanetList(this);
            currentPlanet = galaxy[0];
        }

        public Planet(int age, double money, string name, bool isProsperous)
        {

            this.Age = age;
            this.Money = money;
            this.Name = name;
            this.IsProsperous = isProsperous;
        }

        public void PlanetList()
        {
            Atom atom = new Atom();
            
            int myRandom = RandomNumber();

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
          
            

            Console.WriteLine("\n");
            CenteredString("What planet do you want to go to?");
            CenteredString("1. Earth");
            CenteredString("2. Pluto");
            CenteredString("  3. Waconda");
            CenteredString($" You are at {currentPlanet.Name}");
            //Console.WriteLine();
            atom.ArtAtom();
            int travel = 0;
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D1)
            {
                travel = 0;
            }
            else if (key == ConsoleKey.D2)
            {
                travel = 1;
            }
            else if (key == ConsoleKey.D3)
            {
                travel = 2;
            }
            else
            {
                CenteredString("Invalid Input.");
                TravelToPlanet();
            }
            //int travel = int.Parse(Console.ReadLine());
            //travel -= 1;
            if (currentPlanet == galaxy[travel])
            {
                CenteredString($"Invalid input! You are already at {galaxy[travel].Name}");
                TravelToPlanet();
            }
            


            CenteredString($"You are headed to {galaxy[travel].Name}");

            currentPlanet = galaxy[travel];
            Age += galaxy[travel].Age;

            //Console.WriteLine(atom.age);
            atom.age += Age;

            //Console.WriteLine($"{atom.age} years old");
            Console.WriteLine("");
            CenteredString($" Your age is now {atom.age}!");

            if (myRandom % 3 == 0)
            {
                CenteredString("This Planet has high prices!");
                double loseMoney = (myRandom * 2);
                Money -= (Money * galaxy[travel].Money);
                Money -= loseMoney;
                CenteredString($"You lose {loseMoney}");
            }
            else
            {
                CenteredString("You make money!");
                double makemoney = (myRandom + 50);
                Money += (Money * galaxy[travel].Money);
                Money += makemoney;
                CenteredString($"You make {makemoney}");
            }

            CenteredString($"${Money}");
            Console.WriteLine();
            Console.Clear();
           
            TravelToPlanet();

        }

        private static int RandomNumber()
        {
            Random random = new Random();
            //random.Next(0, 3);
            int myRandom = random.Next(1, 101);
            //Console.WriteLine($"{myRandom} is the random number");
            return myRandom;
        }

        private static List<Planet> NewPlanetList(Planet planet)
        {
            return new List<Planet>
            {
                new Planet(1, 1, "Earth", planet.IsProsperous),
                new Planet(1, 2, "Pluto", planet.IsProsperous),
                new Planet(1, 2.5, "Waconda", planet.IsProsperous)
            };
        }


         public void TravelToPlanet()
        {
           
            Atom atom = new Atom();
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
            Console.ForegroundColor = ConsoleColor.Red;
            CenteredString("");
            CenteredString("Travel to a Planet?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenteredString("Y. yes");
            CenteredString("N. no");     
            CenteredString("");
            atom.ArtEarth();
            //Console.WriteLine("");
            ConsoleKey key = Console.ReadKey(true).Key;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (key == ConsoleKey.Y)
            {
                PlanetList();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                CenteredString("Quit game?");
                Console.WriteLine("\n");
                CenteredString("    ENTER) Quit.          ");
                CenteredString("        N) Return to game.");
                if (key == ConsoleKey.N)
                {
                    PlanetList();
                }
                //string quit = Console.ReadLine();
                //quit = quit.ToUpper();
                //if (quit == "N")
                //{
                //    PlanetList();
                //}
            }

            //string YN = Console.ReadLine();

          
            //YN = YN.ToUpper();
            //if (YN == "Y")
            //{
            //    PlanetList();
            //}
            //else 
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    CenteredString("Quit game?");
            //    Console.WriteLine("\n");
            //    CenteredString("    ENTER) Quit.          ");
            //    CenteredString("        N) Return to game.");
            //    string quit = Console.ReadLine();
            //    quit = quit.ToUpper();
            //    if (quit == "N")
            //    {
            //        PlanetList();
            //    }
                
            //}
            // atom.age += Planet.Current - PlanetList;  
        }
    }
}
