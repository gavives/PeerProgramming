using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
     static class  GameStory
    {
  
        public static void GameStartStory()
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
            CenteredString("the galaxy: Milky Way, was on a mission to");
            CenteredString(" be the richest man in the universe and to achieve");
            CenteredString(" world dominance. He wasn't the only one with this goal.");         
            CenteredString("His arch nemesis Molecule, from the galaxy of Lilypad, had the same idea.");
            CenteredString("In order to achieve his goal, Atom decided to construct a spaceship called Arcadia,");
            CenteredString(" and set off from planet Earth in Arcadia, to space, in order to trade atomic weapons and ammo");
            CenteredString(" to other life forms on different planets for money and goods, in order to destroy Molecule and achieve his");
            CenteredString(" overall goal of world dominance.\n\n\n");
            //CenteredString("");



            // CenteredString("Press any key to advance...");
            //Console.ReadLine();
            atom.money += 100;
            atom.age += 25;
            //CenteredString($"  You have {atom.weapons} weapons");
            //AtomsStats(atom.money += 10);
            //atom.weapons += 2; 
            //atom.spaceship += "Arcadia"; 
            //atom.ammo += 1;

            //AtomsStats();


        }
    }
}
