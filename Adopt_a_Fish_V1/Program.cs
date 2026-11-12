/*
Kevin Diaz
Adopt a Fish
9-17-26
 */

using System.Numerics;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    internal class Program
    {
        public static void Screen()
        {
            Clear();
        }

        static House house = new House();
        static Player player = new Player();
        static Fish fih = new Fish(); 
        static Outside outside = new Outside();
        

        public static void EnterHouse()
        {
            house.Display(player, fih);
        }

        public static void GoOutside()
        {
            outside.Display(player);
        }

        public static void LeaveStore()
        {
            outside.Display(player);
        }

        public static void VisitFish()
        {
            player.tank.Display(player, fih);
        }
        public static void Warming()
        {
            player.tank.WarmWater(player, fih);
        }
        public static void TankChecking()
        {
            player.tank.CheckTank(player, fih);
        }
        public static void FishSwim()
        {
            fih.Swim(player, fih);
        }

        static void Main(string[] args)
        {
            Title = ("Adopt a Fish");

            

            WriteLine("Hello, World!");

            

            WriteLine("Please enter your name");
            
            player.Name = ReadLine();
            Clear();

            WriteLine($"Welcome to Adopt a Fish { player.Name}!");

            WriteLine($"Press any key to start game");
            ReadKey();

            Timer.TimeDisplay();

            Screen();

            
            EnterHouse();

        }
        
    }
}
