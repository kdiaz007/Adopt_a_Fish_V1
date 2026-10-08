/*
Kevin Diaz
Adopt a Fish
9-17-26
 */

using Adopt_a_Fish_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Outside
    {
        House enterhouse = new House();
        Store enterstore = new Store();
        Job enterjob = new Job();
        private bool IsLocked;

        public void EnterHouse(Player player)
        {
            Program.Screen();
            enterhouse.Display(player);
        }

        public void EnterJob(Player player)
        {
            Program.Screen();
            enterjob.Display();
        }

        public void EnterStore(Player player)
        {
            Program.Screen();
            enterstore.Display(player);
        }

        public void CheckTime(Player player)
        {
            Program.Screen();
            WriteLine(Timer.timeDisplay);
        }

        public string Input()
        {
            return ReadLine();
        }

        public void Display(Player player)
        {
            WriteLine("*Outside*");

            WriteLine("\n1 to go to work, 2 to go to store, and 3 to enter house.");
            WriteLine("\nPress T to check time of day.");

            string Key = Input();

            if (Key == "1")
            {
                EnterJob(player);
            }
            else if (Key == "2")
            {
                EnterStore(player);
            }
            else if (Key == "3")
            {
                EnterHouse(player);
            }
            else if (Key == "t")
            {
                CheckTime(player);
            }
            else
            {
                WriteLine("Please press valid keys.");
                ReadKey();
                Program.Screen();
                Display(player);
            }

            Display(player);
        }

    }
}