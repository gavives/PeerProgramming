using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class Atom
    {
        public int weapons; //fuel consumption
        public double money; // money exchange rate
        public int ammo; // names the planet
        public bool isAlive; // set visual and other fun stuff 
        public string spaceship;


        public Atom()
        {
        }

        public Atom(int weapons, double money, int ammo, bool isAlive, string spaceship)
        {
            this.weapons = weapons;
            this.money = money;
            this.ammo = ammo;
            this.isAlive = isAlive;
            this.spaceship = spaceship;
        }

    }
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

    }

    class Program
    {
        static void Main(string[] args)
        {
            // NewPlanet();

            AtomsStats();
            Console.ReadLine();
        }

        private static void AtomsStats()
        {
            Atom atom = new Atom();
            atom.money = 100;
            atom.weapons = 2;
            atom.spaceship = "Arcadia";
            if (atom.money == 100)
            {
                Console.WriteLine(atom.spaceship);
            }
        }

        private static void NewPlanet()
        {
            Planet earth = new Planet();
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
    

    
