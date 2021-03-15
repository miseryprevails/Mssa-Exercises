using System;
using System.Collections.Generic;
using System.Text;


namespace Roulette_Game
{
     class Program
     {

     
        static void Main(string[] args)
        {
            bool play = true;
            while (play == true)
            {
                Play();

                Console.WriteLine("Play again \n Yes or no");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes") play = true;
                else play = false;
                Console.Clear();
            }

           
        }


        public static void Play()
        {
            Wheel wheel = new Wheel();
            Gamble gamble = new Gamble();
            Bets bet = new Bets();

            
            int[] ball  = wheel.Spin();
            int whatColor = ball[0];
            int landed = wheel.Lands(ball);
            string color = wheel.RedOrBlack(whatColor).ToLower();

            int typeOfBet = gamble.WhatKind();

            bool youWon;

            switch (typeOfBet)
            {
                case 1:
                    youWon = bet.NumberBet(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else Console.WriteLine("YAH FUCKIN LOST");
                    break;
                case 2:
                    youWon = bet.EvenOrOdd(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("Winner");
                    }
                    else Console.WriteLine("Broke Bitch");
                    break;
                case 3:
                    youWon = bet.ColorLand(color, landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("Win Win");
                    }
                    else Console.WriteLine("Loser");
                    break;
                case 4:
                    youWon = bet.LowHigh(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("Win");
                    }
                    else
                    {
                        Console.WriteLine("lose");
                    }
                    break;
                case 5:
                    youWon = bet.Dozens(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("Win");
                    }
                    else
                    {
                        Console.WriteLine("lose");
                    }
                    break;
                case 6:
                    youWon = bet.Colums(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("Win");

                    }   
                    else
                    {
                        Console.WriteLine("lose");
                    }
                    break;
                case 7:
                    youWon = bet.Street(landed);
                        if (youWon == true)
                        {
                        Console.WriteLine("Win");
                        }
                    else
                    {
                        Console.WriteLine("lose");
                    }
                    break;
                case 8:
                    youWon = bet.DoubleStreet(landed);
                    if (youWon == true)
                    {
                        Console.WriteLine("win");
                    }
                    else
                    {
                        Console.WriteLine("lose");
                    }
                    break;

            }

           
        }
     }


}  

      






