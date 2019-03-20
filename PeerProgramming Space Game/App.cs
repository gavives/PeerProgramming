using System;

namespace PeerProgramming_Space_Game
{
    internal class App
    {
        public App()
        {
        }

        internal void Run()
        {
         
            Planet planet = new Planet();
            Atom atom = new Atom();

            GameStory.gameStartStory();

            planet.travelToPlanet();

            Console.WriteLine("last line");
            Console.ReadLine();

        }
    }
}