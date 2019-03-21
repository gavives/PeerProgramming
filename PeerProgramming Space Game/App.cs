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

            GameStory.GameStartStory();

            planet.TravelToPlanet();

            ExitStatement();

            Console.ReadLine();

        }

        private static void ExitStatement()
        {

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
            Console.WriteLine("\n\n");
         
            CenteredString("Good bye!");
        }
    }
}