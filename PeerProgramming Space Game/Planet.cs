using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class Planet
    {
        public double gravity; //fuel consumption
        public double money; // money exchange rate
        public string name; // names the planet
        public bool isProsperous; // set visual and other fun stuff 


        public Planet()
        {
        }

        public Planet(double gravity, double money, string name, bool isProsperous)
        {
            this.gravity = gravity;
            this.money = money;
            this.name = name;
            this.isProsperous = isProsperous;
        }
        public void NewPlanet()
        {
           // Planet earth = new Planet();
            List<Planet> galaxy = new List<Planet>();
            galaxy.Add(new Planet(1, 1, "earth", true));
            galaxy.Add(new Planet(.05, 2, "Pluto", false));


            if (galaxy[0].isProsperous)
            {
                Console.WriteLine("You did make money");
            }
            else
            {
                Console.WriteLine("you didnt make money");
            }
        }

    }
}
