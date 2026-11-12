using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Fish
    {
        private string Species = "Betta splendens";
        private int Age;
        public int Hunger = 0;
        private string Color;
        public int Life;
        private int LifeSpent;
        public string Name;

        public string Input()
        {
            return ReadLine();
        }


        public void Swim(Player player, Fish fih)
        {
            Hunger += 2;
            //Gain 2 Hunger
        }

        public void Eat()
        {
            Hunger -= 5;
            //Lose 5 Hunger
        }

        public void Sleep()
        {
            Hunger += 40;
            //Gain 40 Hunger
        }

    }
}