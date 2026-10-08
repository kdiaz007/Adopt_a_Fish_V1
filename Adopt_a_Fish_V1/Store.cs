using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;

namespace Adopt_a_Fish_V1
{
    public class Store
    {
        //Outside leaveStore = new Outside();
        private static readonly string[] names = { "Alice", "Lucy", "Jane", "Belle", "Nicole" };
        private static readonly Random random = new Random();
        public string Cashier = names[random.Next(names.Length)];
        private int ChangeAmt = 1; //What I am using to change the amount in cart
        private int Stock = 0; //This is what's value is currently in your cart
        private int FishFood = 20;

        public void Payment(Player player)
        {
            WriteLine($"*Attended by Cashier {Cashier}*");
            WriteLine($"\n{Cashier}: Hello, are you ready to purchase?");
            WriteLine("\n1 to Pay, and 2 to Return");

            string Key = Input();

            if (Key == "1")
            {
                WriteLine($"{player.Name}: Yes I would like to pay now.");
                ReadKey();
                WriteLine($"\n{Cashier}: Great, please place items down.");
                ReadKey();
                Program.Screen();

                if (Stock == 0)
                {
                    WriteLine($"{Cashier}: Sorry but please grab an item before paying");
                    ReadKey();
                    Program.Screen();
                    Display(player);
                }
                if (player.HasFish == false && Stock > 0)
                {
                    WriteLine($"You currently have one Type Fish in cart, will that be all?");
                }
                else
                {
                    WriteLine($"{Cashier}: You currently have {Stock}x Fish Food in cart, will that be all?");
                }
                WriteLine("\n1 Yes, 2 No");

                string Key2 = Input();

                if (Key2 == "1")
                {
                    if (player.HasFish == false && Stock > 0) //Meant to run when play does not own fish but has in cart c
                    {
                        WriteLine($"{player.Name}: Yes that will be all.");
                        ReadKey();
                        Program.Screen();
                        WriteLine($"{Cashier}: Your total will be 80 dollars.");
                        WriteLine("\nPay Amount");
                        player.Money = player.Money - 80;
                        player.HasFish = true;
                        Stock = 0;
                        WriteLine($"{Cashier}: Here you go.");
                        WriteLine($"\n{Cashier}: Have a nice day!");
                        WriteLine("\nLeave Store");
                        ReadKey();
                        Program.Screen();
                        Program.LeaveStore();
                    }
                    else if (player.HasFish == true && Stock > 0)
                    {
                        WriteLine($"{player.Name}: Yes that will be all");
                        ReadKey();
                        Program.Screen();
                        WriteLine($"{Cashier}: Your total will be {FishFood * Stock} dollars.");
                        WriteLine("\nPay Amount");

                        if (player.Money >= FishFood * Stock)
                        {
                            player.Money = player.Money - FishFood * Stock;
                            player.FishFood = player.FishFood + Stock;
                            Stock = 0;
                            WriteLine($"{Cashier}: Here you go.");
                            WriteLine($"\n{Cashier}: Have a nice day!");
                            WriteLine("\nLeave Store");
                            ReadKey();
                            Program.Screen();
                            Program.LeaveStore();
                        }
                        else if (player.Money  < FishFood * Stock)
                        {
                            Stock = 0;
                            WriteLine($"{Cashier}: Sorry, you do not have enough to purchase this.");
                            ReadKey();
                            Program.Screen();
                            WriteLine("\nYou dramatically run away in shame.");
                            WriteLine($"\n*Come back when you're a little richer {player.Name}*");
                            ReadKey();
                            Program.Screen();
                            Program.LeaveStore();
                        }
                    }

                }
                else if (Key2 == "2")
                {
                    WriteLine($"{player.Name}: Actually, I still have somethings I want to adjust sorry.");
                    ReadKey();
                    WriteLine($"\n{Cashier}: No worries, take your time.");
                    ReadKey();
                    Program.Screen();
                    Display(player);
                }
                else
                {
                    WriteLine("Please press valid keys.");
                    ReadKey();
                    Program.Screen();
                    Payment(player);
                }
            }

            else if (Key == "2")
            {
                WriteLine($"{player.Name}: Sorry, not yet");
                ReadKey();
                Program.Screen();
                Display(player);
            }
            else if (Key == "t")
            {
                CheckTime();
            }
            else
            {
                WriteLine("Please press valid keys.");
                ReadKey();
                Program.Screen();
                Payment(player);
            }

            Display(player);

        }

        public void Market(Player player)
        {
            if (player.HasFish == false)
            {
                WriteLine("Acquire Fish?");
                WriteLine("\n1 Yes, 2 No");

                string Key = Input();

                if (Key == "1")
                {
                    WriteLine("Added Fish to cart!");
                    Stock = Stock++;
                    ReadKey();
                    Program.Screen();
                    Display(player);
                }
                else if (Key == "2")
                {
                    WriteLine("Should I really leave it? I've been meaning to buy one recently.");
                    WriteLine("\nI should buy it now before I forget.");
                    ReadKey();
                    Program.Screen();
                    Market(player);
                }
                else
                {
                    WriteLine("Please press valid keys.");
                    ReadKey();
                    Program.Screen();
                    Market(player);
                }
            }
            else if (player.HasFish == true)
            {
                WriteLine("Acquire Food?");
                WriteLine("\n1 Yes, 2 No");

                string Key = Input();

                if (Key == "1")
                {
                    WriteLine("Added Fish Food to cart!");
                    Stock = Stock++;
                    ReadKey();
                    Program.Screen();
                    Display(player);
                }
                else if (Key == "2")
                {
                    WriteLine("Maybe I shouldn't buy any this time.");
                    ReadKey();
                    Program.Screen();
                    Display(player);
                }
                else
                {
                    WriteLine("Please press valid keys.");
                    ReadKey();
                    Program.Screen();
                    Market(player);
                }
            }
        }

        public void LeaveStore(Player player)
        {
            if (player.HasFish == false && Stock > 0) //Meant to run when the player does not own fish but has it in their cart.
            {
                WriteLine($"Cmon {player.Name}, I can't steal a whole fish.");
                WriteLine("\nLet's pay upfront.");
                ReadKey();
                Program.Screen();
                Display(player);
            }
            if (player.HasFish == false && Stock == 0) //Meant to run if player doesn't own fish but attempts to leave.
            {
                WriteLine("I've been meaning to buy a fish recently.");
                WriteLine("\nI should buy it now before I forget.");
                ReadKey();
                Program.Screen();
                Display(player);
            }
            else if (Stock > 0 && player.HasFish == true) //Meant to run after the player owns fish but is attempting to leave with food in cart.
            {
                WriteLine($"Cmon {player.Name}, I shouldn't be a thief.");
                WriteLine("\nLet's pay upfront.");
                ReadKey();
                Program.Screen();
                Display(player);
            }
            else
            {
                Program.Screen();
                Program.LeaveStore();
            }
        }

        public void Adjust(Player player)
        {
            Program.Screen();
            WriteLine("Adjust Cart");
            WriteLine("\n1 Increase Amount, 2 Decrease Amount, 3 Leave");
            WriteLine("\nPress T to check time of day.");

            string Key = Input();

            if (Key == "1")
            {
                if (player.HasFish == false && Stock > 1) //Meant to run when you have fish in cart and are trying to add increase amount.
                {
                    WriteLine("I can't afford another.");
                    WriteLine("\nLet's be content with just this one.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);
                }
                else if (player.HasFish == true && Stock > 1) //Meant to run after you own fish and are attempting to increase food amount.
                {
                    Stock = Stock + ChangeAmt;

                    WriteLine($"You have {Stock} fish food in cart.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);
                }
                else //Else if none of the above run, that hopefully means the cart is empty and this below runs as planned.
                {
                    WriteLine("Cart is currently empty.");
                    WriteLine("\n Add items to begin adjusting.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);
                }
            }
            else if (Key == "2")
            {
                if (player.HasFish == false && Stock > 1) //Meant to run when player does not own fish but has it in cart.
                {
                    WriteLine("Should I really leave it? I've been meaning to buy one recently.");
                    WriteLine("\nI should buy it now before I forget.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);
                }
                else if (player.HasFish == true && Stock > 1) //Meant to run when player as fish and is decreasing food amount.
                { 
                    Stock = Stock - ChangeAmt;
                    WriteLine($"You have {Stock} fish food in cart.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);

                }
                else
                {
                    WriteLine("Cart is currently empty.");
                    WriteLine("\n Add items to begin adjusting.");
                    ReadKey();
                    Program.Screen();
                    Adjust(player);
                }
                   
            }
            else if (Key == "3")
            {
                Program.Screen();
                Display(player);
            }
            else if (Key == "t")
            {
                CheckTime();
            }
            else
            {
                WriteLine("Please press valid keys.");
                ReadKey();
                Program.Screen();
                Adjust(player);
            }

        }

        public void CheckTime()
        {
            Program.Screen();
            WriteLine(Timer.timeDisplay);
        }

        public string Input()
        {
            return ReadLine();
        }

        public void Display(Player player)
        {
            WriteLine("You are at store");

            WriteLine("\n1 to go to Cashier, 2 visit market, 3 to adjust cart, and 4 to leave store.");
            WriteLine("\nPress T to check time of day.");

            string Key = Input();

            if (Key == "1")
            {
                Payment(player);
            }
            else if (Key == "2")
            {
                Market(player);
            }
            else if (Key == "3")
            {
                Adjust(player);
            }
            else if (Key == "4")
            {
                LeaveStore(player);
            }
            else if (Key == "t")
            {
                CheckTime();
            }
            else
            {
                WriteLine("Please press valid keys.");
                ReadKey();
                Program.Screen();
                Display(player);
            }

            Display(player);
        }

        
    }
}