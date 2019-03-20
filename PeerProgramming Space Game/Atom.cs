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
        public int age;
        

        public Atom()
        {

        }

        public Atom(int weapons, double money, int ammo, bool isAlive, int age)
        {
            this.weapons = weapons;
            this.money = money;
            this.ammo = ammo;
            this.isAlive = isAlive;
            this.age = age;
            
        }


       
    }
}
