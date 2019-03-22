﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgramming_Space_Game
{
    class WareHouse
    {
        public void WarehouseMenu()
        {
            Planet planet = new Planet();
            Atom atom = new Atom();
            

            int menu = MenuOptions();
            bool exit = true;

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


            //MenuOptions();


            while (exit)
            {
                menu.ToString();

                switch (menu)
                {

                    case 1:
                        CenteredString($" You have ${atom.Money}");
                        break;
                    case 2:
                        
                        CenteredString("How many weapons do you want to buy? ");
                        int purchaseWeapon = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{purchaseWeapon} weapons purchased");
                        // atom.money -= 5 * purchaseWeapon;
                        atom.weapons += purchaseWeapon;
                        atom.Money -= purchaseWeapon * 10;
                        Console.WriteLine($"${atom.Money} money. {atom.weapons} weapons");
                        //CenteredString(atom.money.ToString());
                        break;
                    case 3:
                        CenteredString("BUY FUEL");
                        break;
                    case 4:
                        CenteredString("SELL WEAPONS");
                        break;
                    case 5:
                        CenteredString("SELL FUEL");
                        break;
                    case 6:
                        CenteredString("Exit");
                        exit = false;
                        break;
                }
                CenteredString("menu again? Y or N");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Y)
                {
                    Console.Clear();
                    MenuOptions();
                }
                else if (key == ConsoleKey.N)
                {
                    exit = false;
                }
               
                // Console.Clear();

            }

        }
        private int MenuOptions()
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

            CenteredString("1) MONEY");
            CenteredString("   2) WEAPONS");
            CenteredString("3) Fuel");
            CenteredString("        4) SELL WEAPONS");
            CenteredString("    5) SELL FUEL");
            CenteredString("      6) Leave menu");

            return int.Parse(Console.ReadLine());

        }

    }
}
