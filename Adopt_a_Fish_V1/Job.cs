using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;


//"_name" lowercase and underscore for privates and "Name" for public

namespace Adopt_a_Fish_V1
{
    public class Job
    {
        private bool ShiftDone;
        private int CorrectPay;

        public int problem = 20;

        public void LeaveJob()
        {
            Program.GoOutside();
        }

        public void CheckTime(Player player)
        {
            Program.Screen();
            WriteLine(Timer.timeDisplay);
            Thread.Sleep(500);
            if (KeyAvailable)
            {

            }
            else
            {

                CheckTime(player);
            }
            Clear();
        }

        public void MathManager()
        {
            /*During the day the player has 20 problems to answer
             * The player can leave at anytime
             * the problems each contain of 2 double digit numbers being either added or subtracted
             * Each correct problem will reward 4 dollars; Equalling 80 dollars assuming how answers are correct
             */

        }

        public void Display()
        {
            WriteLine("You are at job");
            ReadKey();
            WriteLine($"\nYou have {problem} questions to solve!");
            ReadKey();
            WriteLine("| Start Working |");
        }
    }
}