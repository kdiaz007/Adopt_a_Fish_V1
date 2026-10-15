using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Tank
    {
        Timer time = new Timer();

        public int Temp;
        private bool IsOutofTemp;
        private int IncreaseTemp;
        private int DecreaseTemp;
        private int OutTempTime;

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
                Program.Screen();
                Program.EnterHouse();
            }
        }

        public void DrainHP()
        {
            throw new System.NotImplementedException();
        }

        public void LeaveFish()
        {
            throw new System.NotImplementedException();
        }

        public void WarmWater()
        {
            //Temp -= time.WarmWater;
        }
    }
}