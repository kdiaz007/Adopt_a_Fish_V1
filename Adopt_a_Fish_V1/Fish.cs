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
        private string Name;

        public void Display()
        {
            WriteLine("We are viewing the fish!");
            ReadKey();
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