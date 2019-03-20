using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class Planet
    {
        private int age; //fuel consumption
        private double money; // money exchange rate
        private string name; // names the planet
        private bool isProsperous; // set visual and other fun stuff 

        public int Age { get => age; set => age = value; }
        public double Money { get => money; set => money = value; }
        public string Name { get => name; set => name = value; }
        public bool IsProsperous { get => isProsperous; set => isProsperous = value; }

        public Planet()
        {
        }

        public Planet(int age, double money, string name, bool isProsperous)
        {

            this.age = age;
            this.Money = money;
            this.Name = name;
            this.IsProsperous = isProsperous;
        }
        public void PlanetList()
        {
            
            //Atom atom = new Atom();
            Planet planet = new Planet();
            //Random random = new Random();



            //// random.Next(0, 3);
            //int myRandom = random.Next(0, 10);


            List<Planet> galaxy = new List<Planet>();
            galaxy.Add(new Planet(1, 1, "Earth", planet.IsProsperous));
            galaxy.Add(new Planet(2, 2, "Pluto", planet.IsProsperous));
            galaxy.Add(new Planet(10, 2.5, "Waconda", planet.IsProsperous));

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
                

            int travel = int.Parse(Console.ReadLine());
                travel -= 1;
                galaxy.ToArray();
                CenteredString($"You are headed to {galaxy[travel].Name}");
                Age += galaxy[travel].age;
                Console.WriteLine(age);
            travelToPlanet();


        }
        public void travelToPlanet()
        {
            Atom atom = new Atom();
            Console.WriteLine("Travel to a Planet?");
            Console.Write("Y. yes \nN. no");
            string YN = Console.ReadLine();
            YN = YN.ToUpper();
            if (YN == "Y")
            {
                PlanetList();
            }
            


           // atom.age += Planet.Current - PlanetList;

           
        }

    }
}
