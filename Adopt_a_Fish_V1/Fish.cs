using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Fish
    {
        private string Species;
        private int Age;
        public int Hunger;
        private string Color;
        public int Life;
        private bool IsOwned;
        private int LifeSpent;
        public string Name;

        public string Input()
        {
            return ReadLine();
        }

        public void Display(Player player)
        {
            if (player.HasFish == false)
            {
                WriteLine("We are viewing the fish bowl!");
                ReadKey();
                WriteLine("It's kind of depressing with no fish.");
                ReadKey();
                WriteLine("I should get one soon.");
                ReadKey();
            }
            else if (player.HasFish == true)
            {
                WriteLine("We are viewing the fish bowl");
                ReadKey();
               // WriteLine($"How has you day been {fih.Name}?");
            }

        }

        public void Swim()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void Sleep()
        {
            throw new System.NotImplementedException();
        }

        public void Tank()
        {
            throw new System.NotImplementedException();
        }
    }
}