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
        
        
        public void AtomsStats()
        {
            Random random = new Random();
            // random.Next(0, 3);
            int myRandom = random.Next(0, 3);
            money = 0;
            weapons = 0;
            spaceship = "Arcadia";
            //if (money / 2 == 1)
            //{
            //    Console.WriteLine(spaceship);
            //}
            //else
            //{
            //    Console.WriteLine("You were shot down");
            //}
        }
    }
}
