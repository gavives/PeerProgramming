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
        //public double money; // money exchange rate
        public int ammo; // names the planet
        public bool isAlive; // set visual and other fun stuff 
        public int age;
        public int fuel;
        public double Money { get; set; } = 1000;

        public Atom()
        {

        }

        public Atom(int weapons, double money, int ammo, bool isAlive, int age, int fuel)
        {
            this.weapons = weapons;
            this.Money = money;
            this.ammo = ammo;
            this.isAlive = isAlive;
            this.age = age;
            this.fuel = fuel;
            
        }
        public void ArtEarth()
        {
            //void CenteredString(string s)
            //{
            //    if (s.Length <= Console.WindowWidth)
            //    {
            //        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            //        Console.WriteLine(s);
            //    }
            //    else
            //    {
            //        throw new Exception("Oversided String");
            //    }
            //}
            Console.WriteLine(@"              _____");
            Console.WriteLine(@"          .-'.  ':'  -.");
            Console.WriteLine(@"        .''::: .:      '.");
            Console.WriteLine(@"       /   :::::'        \");
            Console.WriteLine(@"      ;.    ':' `         ;");
            Console.WriteLine(@"      |       '..         |");
            Console.WriteLine(@"      ; '      ::::.      ;");
            Console.WriteLine(@"       \       '::::     /");
            Console.WriteLine(@"        '.      :::    .'");
            Console.WriteLine(@"           '-.___'_.-'");
        }
        public void ArtAtom()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("	                   							          <>" +
  "		   								                   .-\"\"\" -.       ||::::::==========\n " +
  "									  /=       \\      ||::::::==========\n" +
  "									  |- /~~~\\  |     ||::::::==========\n" +
  "									  |=( '.' ) |     ||================\n" +
  "									  \\__\\_=_/__/     ||================\n" +
  "									   {_______}      ||================\n" +
  "									 /` *       `'--._||\n" +
  "									/= .     [] .     { >\n" +
  "								       /  /|ooo     |`'--'||\n" +
  "								      (   )\\_______/      ||\n" +
  "								       \\``\\/       \\      ||\n" +
  "									`-| ==    \\_|     ||\n" +
  "									  /         |     ||\n" +
  "									 |=   >\\  __/     ||\n" +
  "									 \\   \\ |- --|     ||\n" +
  "									  \\ __| \\___/     ||\n" +
  "								          _{__} _{__}     ||\n" +
  "									 (    )(    )     ||\n" +
  "								 ^^~  `\"\"\"  `\"\"\"  ~^^^~^^~~~^^^~^^^~^^^~^^~^");

        }


    }
}
