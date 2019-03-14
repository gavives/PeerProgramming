using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
 
    

    class Program
    {
        static void Main(string[] args)
        {
            // Planet planet = new Planet();
            //  planet.NewPlanet();
            // Atom atom = new Atom();
            // atom.AtomsStats();

            
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
            //Console.ReadKey();
            
            // Potentially add in menu to go to different planets
            

            Console.ReadLine();
            
        }
        







    }

}
    

    
