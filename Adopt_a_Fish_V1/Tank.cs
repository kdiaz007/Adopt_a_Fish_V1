using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Tank
    {

        public int Temp = 90;
        private bool IsOutofTemp;
        private int OutTempTime;


        public string Input()
        {
            return ReadLine();
        }

        public void Display(Player player, Fish fih)
        {
            if (player.HasFish == true && player.HasNamedFish == false)
            {
                WriteLine("What should I name my new fish?");
                WriteLine("\nEnter Fish Name");

                fih.Name = ReadLine();
                Program.Screen();
                player.HasNamedFish = true;
                WriteLine($"It's nice to meet you {fih.Name}!");
                ReadKey();
                WriteLine("\nPress any key to return to main room");
                ReadKey();
                Program.Screen();
                Program.EnterHouse();

            }
            else if (player.HasFish == false)
            {
                WriteLine("We are viewing the fish bowl!");
                ReadKey();
                WriteLine("It's kind of depressing with no fish.");
                ReadKey();
                WriteLine("I should get one soon.");
                ReadKey();
                Program.Screen();
                Program.EnterHouse();
            }
            else if (player.HasFish == true)
            {
                WriteLine("We are viewing the fish bowl");
                ReadKey();
                WriteLine($"How has you day been {fih.Name}?");
                ReadKey();
                WriteLine("\n1 to feed, 2 to check fish tank, and 3 to go back.");

                string Key = Input();

                if (Key == "1")
                {
                    Program.Screen();
                    Feed(player, fih);
                }
                else if (Key == "2")
                {
                    Program.Screen();
                    CheckTank(player, fih);
                }
                else if (Key == "3")
                {
                    Program.Screen();
                    Program.EnterHouse();
                }
                else
                {
                    WriteLine("Please press valid keys.");
                    ReadKey();
                    Program.Screen();
                    Display(player, fih);
                }
            }
        }

        public void Feed(Player player, Fish fih)
        {
            throw new System.NotImplementedException();
        }

        public void CheckTank(Player player, Fish fih)
        {
            WriteLine("Recommended Temperture = 70-90");
            WriteLine($"\nCurrent Temperture = {Temp}");

            WriteLine("\n*leaving water out of temp for more than a minute reduce your fish life health*");

            WriteLine("\n1 to Leave, 2 to Increase Temp, 3 to Decrease Temp");

            string Key = Input();

            if(Key == "1")
            {
                Program.Screen();
                Display(player, fih);
            }
            else if (Key == "2")
            {
                Temp = Temp + 2;
                Program.Screen();
                CheckTank(player, fih);
            }
            else if (Key == "3")
            {
                Temp = Temp - 2;
                Program.Screen();
                CheckTank(player, fih);
            }
            else
            {
                WriteLine("Please press valid keys.");
                ReadKey();
                Program.Screen();
                Display(player, fih);
            }
        }

        public void DrainHP()
        {
            throw new System.NotImplementedException();
        }

        public void WarmWater()
        {
            //Temp -= time.WarmWater;
        }
    }
}