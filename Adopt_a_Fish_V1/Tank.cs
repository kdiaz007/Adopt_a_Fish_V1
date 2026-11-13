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


        public string Input()
        {
            return ReadLine();
        }

        public void Display(Player player, Fish fih)
        { 

            if (player.HasFish == true && Player.HasNamedFish == false)
            {
                WriteLine("What should I name my new fish?");
                WriteLine("\nEnter Fish Name");

                fih.Name = ReadLine();
                Program.Screen();
                Player.HasNamedFish = true;
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

                WriteLine($"How has your day been {fih.Name}?");
                WriteLine($"\n{fih.Name} Hunger - \"{fih.Hunger}/100\"");
                WriteLine("\n*REFRESH OFTEN as when on this screen the hunger is still increasing behind scenes even if it's not going up visually!*");
                WriteLine("\n| 1 to feed | 2 to check fish tank | 3 to go back | 4 to REFRESH |");

                //string Key = Input();
                string Key = ReadLine();

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
                else if (Key == "4")
                {
                    Program.Screen();
                    Display(player, fih);
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
            if (player.FishFood <= 0)
            {
                Clear();
                WriteLine("You don't have any fish food at the moment");
                ReadKey();
                Display(player, fih);
            }
            else if (player.FishFood >= 1)
            {
                Clear();
                WriteLine($"You current have {player.FishFood} Fish Treat.");
                WriteLine("\n| 1 to feed 1x Fish Treat | 2 to Leave |");

                string Key = Input();

                if (Key == "1")
                {
                    fih.Eat();
                    Clear();
                    Display(player, fih);
                }
                else if (Key == "2")
                {
                    Clear();
                    Display(player, fih);
                }
            }
        }

        public void CheckTank(Player player, Fish fih)
        {

            WriteLine("Recommended Temperture = 70-90");
            WriteLine($"\nCurrent Temperture = {Temp}");

            WriteLine("\n*leaving water out of temp for more than a minute reduce your fish life health*");
            Write($"\n{Program.fih.Endurance}");
            Write($"\n{Program.fih.Life}");


            WriteLine("\n1 to Leave, 2 to Increase Temp, 3 to Decrease Temp");

            if (Temp > 90 || Temp < 70)
            {
                Drain(player, fih);
            }

            string Key = Input();



            if(Key == "1")
            {
               
                Program.Screen();
                Display(player, fih);
            }
            else if (Key == "2")
            {
                Temp += 2;
                Program.Screen();
                CheckTank(player, fih);
            }
            else if (Key == "3")
            {
                Temp -= 2;
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

        public void Drain(Player player, Fish fih)
        {
            if (fih.Hunger >= 100)
            {
                fih.MaxAge -= 1;
            }
            else if (fih.Hunger >= 150)
            {
                fih.MaxAge -= 1;
            }
            else if (fih.Hunger >= 200)
            {
                fih.MaxAge -= 1;
            }

            if (Temp > 90 || Temp <70 && fih.Endurance > 0)
            {
                fih.Endurance -= 10;
                Temp = 90;
            }
            else if (Temp > 90 || Temp < 70 && fih.Endurance == 0)
            {
                fih.Life -= 10;
                Temp = 90;
            }
        }

        public void WarmWater(Player player, Fish fih)
        {
            Temp = Temp + Timer.result;
        }
    }
}