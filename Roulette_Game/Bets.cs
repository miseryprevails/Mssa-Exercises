using System;
using System.Collections.Generic;
using System.Text;



namespace Roulette_Game
{
	public class Bets
	{
		public bool NumberBet(int landed, double bet)
		{

			Console.WriteLine("what number do you want to bet on");
			int playerBet = Int32.Parse(Console.ReadLine());
			Console.WriteLine($"PLayer bet on: {playerBet}");
			Console.WriteLine($"ball landed on:  {landed}");

			bool winner = false;

			if (landed == playerBet)
			{
				return winner = true;
				bet *= 35;
				
			}
			else return winner;
		}

		public bool EvenOrOdd(int landed)
		{
			Console.WriteLine("Even or Odd");
			string result = Console.ReadLine().ToLower();

			bool winLose = false;


			Console.WriteLine($"Ball landed on {landed}");

			if (result == "even" && landed % 2 == 0)
			{
				return winLose = true;
			}
			else if (result == "odd" && landed % 2 != 0)
			{
				return winLose = true;
			}
			else return winLose;
		}
		public bool ColorLand(string color, int landed)
		{
			Console.WriteLine("red or Black");
			string result = Console.ReadLine().ToLower();
			Console.WriteLine($"Ball landed on {landed}, Color is: {color}");
			bool winLose = false;

			if (color == result) return winLose = true;
			else return winLose;
		}
		public bool LowHigh(int landed)
		{
			Console.WriteLine("Low(1-18) or High (19-38), Choose one");
			string result = Console.ReadLine().ToLower();
			Console.WriteLine($"Ball landed on number {landed}");
			bool winLose = false;
			if (result == "low" && landed <= 18)
			{
				return winLose = true;
			}
			else if (result == "high" && landed >= 19)
			{
				return winLose = true;
			}

			else return winLose;
		}
		public bool Dozens(int landed)
		{
			Console.WriteLine("Which Third? Choose a number! ");
			Console.WriteLine("1. First Third 1-12");
			Console.WriteLine("2. Second Third 13 - 24");
			Console.WriteLine("3. Last Third 25-36");
			



			int result = Int32.Parse(Console.ReadLine());

			Console.WriteLine($"The ball landed on {landed}");
			bool winLose = false;
			if (result == 1 && landed >= 1 && landed <= 12)
			{
				return winLose = true;
			}
			else if (result == 2 && landed >= 13 && landed <= 24)
			{
				return winLose = true;

			}
			else if (result == 3 && landed >= 25 && landed <= 36)
			{
				return winLose = true;
			}
			else return winLose;
		}
		public bool Colums(int landed)
		{

			int[] firstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
			int[] secondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
			int[] thirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };




			Console.WriteLine("Which Column?");
			Console.WriteLine("1. First Column ");
			Console.WriteLine("2. Second Column");
			Console.WriteLine("3. Third Column");

			int userNumber = Int32.Parse(Console.ReadLine());
			bool win = false;
			Console.WriteLine($"The ball landed on {landed}");
			switch (userNumber)
			{
				case 1:
					foreach (int num in firstColumn)
					{
						if (num == landed)
						{
							return win = true;
						}

					}
					break;
				case 2:

					foreach (int num in secondColumn)
					{
						if (num == landed)
						{
							return win = true;
						}

					}
					break;
				case 3:
					foreach (int num in thirdColumn)
					{
						if (num == landed)
						{
							return win = true;
						}


					}
					break;



			}
			return win;
		}
		
		
			public bool Street(int landed)
            {

				int[] Col1 = { 1, 2, 3 };
				int[] Col2 = { 4, 5, 6 };
				int[] Col3 = { 7, 8, 9 };
				int[] Col4 = { 10, 11, 12 };
				int[] Col5 = { 13, 14, 15 };
				int[] Col6 = { 16, 17, 18 };
				int[] Col7 = { 19, 20, 21 };
				int[] Col8 = { 22, 23, 24 };
				int[] Col9 = { 25, 26, 27 };
				int[] Col10 = { 28, 29, 30 };
				int[] Col11 = { 31, 32, 33 };
				int[] Col12 = { 34, 35, 36 };

				bool winner = false;
				Console.WriteLine("Which street?");
				Console.WriteLine("1. street 1/2/3");
				Console.WriteLine("2. street 4/5/6");
				Console.WriteLine("3. street 7/8/9");
				Console.WriteLine("4. street 10/11/12");
				Console.WriteLine("5. street 13/14/15");
				Console.WriteLine("6. street 16/17/18");
				Console.WriteLine("7. street 19/22/21");
				Console.WriteLine("8. street 22/23/24");
				Console.WriteLine("9. street 25/26/27");
				Console.WriteLine("10. street 28/29/30");
				Console.WriteLine("11. street 31/32/33");
				Console.WriteLine("12. street 34/35/36");


				int userNumber = Int32.Parse(Console.ReadLine()); 

				Console.WriteLine($"The ball landed on {landed}");
                switch(userNumber)
				{
					case 1:
						foreach (int i in Col1)
						{
							if (i == landed) winner = true;
						}
						break;
					case 2:
						foreach (int i in Col2)
						{
							if (i == landed) winner = true;
						}
						break;
					case 3:
						foreach (int i in Col3)
						{
							if (i == landed) winner = true;
						}
						break;
					case 4:
						foreach (int i in Col4)
						{
							if (i == landed) winner = true;
						}
						break;
					case 5:
						foreach (int i in Col5)
						{
							if (i == landed) winner = true;
						}
						break;
					case 6:
						foreach (int i in Col6)
						{
							if (i == landed) winner = true;
						}
						break;
					case 7:
						foreach (int i in Col7)
						{
							if (i == landed) winner = true;
						}
						break;
					case 8:
						foreach (int i in Col8)
						{
							if (i == landed) winner = true;
						}
						break;
					case 9:
						foreach (int i in Col9)
						{
							if (i == landed) winner = true;
						}
						break;
					case 10:
						foreach (int i in Col10)
						{
							if (i == landed) winner = true;
						}
						break;
					case 11:
						foreach (int i in Col11)
						{
							if (i == landed) winner = true;
						}
						break;
					case 12:
						foreach (int i in Col12)
						{
							if (i == landed) winner = true;
						}
						break;
				}
				return winner;


			




			}


			public bool DoubleStreet(int landed)
            {
	
				int[] col1 = { 1, 2, 3, 4, 5, 6 };
				int[] col2 = { 7, 8, 9, 10, 11, 12 };
				int[] col3 = { 13, 14, 15, 16, 17, 18 };
				int[] col4 = { 19, 20, 21, 22, 23, 24 };
				int[] col5 = { 25, 26, 27, 28, 29, 30 };
				int[] col6 = { 31, 32, 33, 34, 35, 36 };


				bool winner = false;
				Console.WriteLine("Pick what double street you want to play? Pick a number");
				Console.WriteLine("1. Double Street 1 (1, 2, 3, 4, 5, 6)");
				Console.WriteLine("2. Double Street 2 (7, 8, 9, 10, 11, 12)");
				Console.WriteLine("3. Double Street 3 (13, 14, 15, 16, 17, 18)");
				Console.WriteLine("4. Double Street 4 (19, 20, 21, 22, 23, 24)");
				Console.WriteLine("5. Double Street 5 (25, 26, 27, 28, 29, 30)");
				Console.WriteLine("6. Double Street 6 (31, 32, 33, 34, 35, 36)");

			



				int userNumber = Int32.Parse(Console.ReadLine());

				Console.WriteLine($"The ball landed on {landed}");



			switch (userNumber)
			{ 


				case 1:
					foreach (int i in col1)
					{
						if (i == landed) winner = true;
					}
					break;
				case 2:
					foreach (int i in col2)
					{
						if (i == landed) winner = true;
					}
					break;
				case 3:
					foreach (int i in col3)
					{
						if (i == landed) winner = true;
					}
					break;
				case 4:
					foreach (int i in col4)
					{
						if (i == landed) winner = true;
					}
					break;
				case 5:
					foreach (int i in col5)
					{
						if (i == landed) winner = true;
					}
					break;
				case 6:
					foreach (int i in col6)
					{
						if (i == landed) winner = true;
					}
					break;
				
				}
			
			
				return winner;

			}

            



		
	}
}
