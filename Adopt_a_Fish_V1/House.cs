using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class House
    {
        Outside outside = new Outside();
        Fish fih = new Fish();

        public void LeaveHouse(Player player)
        {
            Program.Screen();
            outside.Display(player);
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

        public void EnterFish(Player player)
        {
            Program.Screen();
            fih.Display();
        }

        public void Sleep()
        {
            throw new System.NotImplementedException();
        }

        public void Display(Player player)
        {

            WriteLine($"We are in the house {player.Name}!");
            WriteLine($"You are {player.Age} years old.");
            WriteLine($"And have {player.Money} dollars.");
            
            WriteLine("\n1 to Sleep, 2 to Leave House, and 3 to check Fish.");
            WriteLine("\nPress T to check time of day.");

            string Key = Input();

            if (Key == "2")
            {
                LeaveHouse(player);
            }
            else if (Key == "3")
            {
                EnterFish(player);
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