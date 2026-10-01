using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Timer
    {
        /*I want to make the total day time to be 7 minutes
        
        I want the player to wake at 6 am and sleep at 9pm

        DONE -- This mean the player will play 15 hours of in-game time over 7 minutes

        DONE -- Each real life second I will add 128.5714 to the RawTime.

        */

        public static double RawTime = 0; //Where time is counted
        public static bool Has5Passed = false; //Once 5 IRL seconds passed the fish will swim. The value in code will be 6
        public static int currentHour = 6;
        public static int currentMinute = 0;
        public static bool Has2MinPassed = false; //Once 2 IRL Minutes passed WarmWater - Temp will happen
        

        public static Random WarmWater = new Random();

        public static int GetRandomNumber(int max)
        {
            return WarmWater.Next(max);
        }
        //random value of 8-15
        // ^Add overload to WarmWater^ Not done with this yet

        private static System.Timers.Timer MainTimer;
        private static System.Timers.Timer FiveTimer;
        private static System.Timers.Timer TwoMinTimer;

        public static void TimeDisplay()
        {
            RunMainTimer();
            Run5Timer();
            Run2MinTimer();

            ReadLine();
        }

        private static void RunMainTimer()
        {
            MainTimer = new System.Timers.Timer(1000);
            MainTimer.Elapsed += OnMainTimedEvent;
            MainTimer.AutoReset = true;
            MainTimer.Start();
        }

        private static void Run5Timer()
        {
            FiveTimer = new System.Timers.Timer(5000);
            FiveTimer.Elapsed += OnFiveTimedEvent;
            FiveTimer.AutoReset = true;
            FiveTimer.Start();
        }

        private static void Run2MinTimer()
        {
            TwoMinTimer = new System.Timers.Timer(120000);
            TwoMinTimer.Elapsed += OnTwoMinTimedEvent;
            TwoMinTimer.AutoReset = true;
            TwoMinTimer.Start();
        }

        private static void OnMainTimedEvent(Object source, ElapsedEventArgs e)
        {
            RawTime += 128.5714;

            double hoursPassed = RawTime / 3600.0;
            double minutesPassed = (RawTime % 3600.0) / 60.0;

            currentHour = 6 + (int)hoursPassed;
            currentMinute = (int)minutesPassed;

            string timeDisplay = $"{currentHour:D2}:{currentMinute:D2}";


            Clear();
            WriteLine($"The time is {timeDisplay}.");

            if (Has5Passed == true)
            {
                Has5Passed = false;
            }

            if (Has2MinPassed == true)
            {
                Has2MinPassed = false;
            }

            DayEnd();

        }

        private static void OnFiveTimedEvent(Object source, ElapsedEventArgs e)
        {
            Has5Passed = true;
        }

        private static void OnTwoMinTimedEvent(Object source, ElapsedEventArgs e)
        {
            Has2MinPassed = true;
        }


        public static void DayEnd() //Day End will start once RawTime = 6942855.6 <- this number equals 54,000 IRL seconds and will equate to 7 minutes IRL
        {
            if (RawTime >= 6942855.6) //7 Minutes IRL = The 15 hours you spent In-Game
            {
                //I was searching on Google for help on this. Apparently the ? helps in case it goes null and instead of crashing it will just skip it.
                MainTimer?.Stop();
                MainTimer?.Dispose();
                FiveTimer?.Stop();
                FiveTimer?.Dispose();
                TwoMinTimer?.Stop();
                TwoMinTimer?.Dispose();

                WriteLine("\nIm feeling tired, I should head to sleep");
                WriteLine("Press [Enter] to close the window.");
            }
        }

        public void NewDay() //NewDay will reset RawTime back to 0
        {
            throw new System.NotImplementedException();
        }
    }
}