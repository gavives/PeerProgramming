using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class Planet
    {
        private double gravity; //fuel consumption
        private double money; // money exchange rate
        private string name; // names the planet
        private bool isProsperous; // set visual and other fun stuff 

        public double Gravity { get => gravity; set => gravity = value; }
        public double Money { get => money; set => money = value; }
        public string Name { get => name; set => name = value; }
        public bool IsProsperous { get => isProsperous; set => isProsperous = value; }

        public Planet()
        {
        }

        public Planet(double gravity, double money, string name, bool isProsperous)
        {

            this.Gravity = gravity;
            this.Money = money;
            this.Name = name;
            this.IsProsperous = isProsperous;
        }
        

    }
}
