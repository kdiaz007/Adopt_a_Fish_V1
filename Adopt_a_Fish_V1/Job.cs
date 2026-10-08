using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


//"_name" lowercase and underscore for privates and "Name" for public

namespace Adopt_a_Fish_V1
{
    public class Job
    {
        private bool ShiftDone;
        private int CorrectPay;

        public void LeaveJob()
        {
            throw new System.NotImplementedException();
        }

        public void CheckTime()
        {
            throw new System.NotImplementedException();
        }

        public void Display()
        {
            WriteLine("You are at job");
            ReadKey();
        }
    }
}