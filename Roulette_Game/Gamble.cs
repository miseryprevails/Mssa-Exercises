using System;
using System.Collections.Generic;
using System.Text;


namespace Roulette_Game
{ 
	public class Gamble
	 {

		
		

		public int WhatKind()
		{
			Console.WriteLine("What kind of Bet?");
			Console.WriteLine("1. Number Bet?");
			Console.WriteLine("2. Even or Odd?");
			Console.WriteLine("3. Black or Red?");
			Console.WriteLine("4. Low or High?" );
			Console.WriteLine("5. Gamble on the dozens");
			Console.WriteLine("6. Bet the ball landing in 1, 2, or 3");
			Console.WriteLine("7. Street: rows, 1/2/3 or 22/23/24");
			Console.WriteLine("8. Double street rows");
			int playerBet = Int32.Parse(Console.ReadLine());

			return playerBet;


		}

	 }

}

