/*
Kevin Diaz
Adopt a Fish
9-17-26
 */

using static System.Console;

namespace Adopt_a_Fish_V1
{
    internal class Program
    {
        public static void Screen()
        {
            Clear();
        }

        static void Main(string[] args)
        {
            Title = ("Adopt a Fish");

            House house = new House();

            WriteLine("Hello, World!");

            Player player = new Player();

            WriteLine("Please enter your name");
            
            player.Name = ReadLine();
            Clear();

            WriteLine($"Welcome to Adopt a Fish { player.Name}!");

            WriteLine($"Press any key to start game");
            ReadKey();

            Screen();

            house.Display(player);


        }
        
    }
}
