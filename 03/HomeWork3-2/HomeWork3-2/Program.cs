using System;

namespace HomeWork3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[,] mas = new int[10, 10];
			//for(int i = 1; i < 10; i++)
			//{
			//    for (int j = 1; j < 10; j++)
			//    {
			//        mas[i, j] = i * j;
			//        Console.Write(mas[i, j]);
			//    }
			//    Console.WriteLine("\n"); 


			// declare constants
			const int horizontalFirstItem = 1;
			const int horizontalStep = 1;
			const int horizontalItemsCount = 10;

			const int verticalFirstItem = 1;
			const int verticalStep = 1;
			const int verticalItemsCount = 10;

			// define horizontal multipliers
			var horizontalItems = new int[horizontalItemsCount];
			for (int i = 0; i < horizontalItemsCount; i++)
			{
				horizontalItems[i] = horizontalFirstItem + i * horizontalStep;
			}

			// define vertical multipliers
			var verticalItems = new int[verticalItemsCount];
			for (int i = 0; i < verticalItemsCount; i++)
			{
				verticalItems[i] = verticalFirstItem + i * verticalStep;
			}

			// display the first line with additional "magic" shift
			Console.Write("   *");
			for (int i = 0; i < horizontalItemsCount; i++)
			{
				Console.Write(horizontalItems[i].ToString().PadLeft(4));
			}

			// breaking the first line
			Console.WriteLine();

			// display the rest of the table line by line
			for (int j = 0; j < verticalItemsCount; j++)
			{
				for (int i = 0; i < horizontalItemsCount; i++)
				{
					// if we just started a new row
					if (i == 0)
					{
						// display the corresponding vertical multiplier first
						Console.Write(verticalItems[j].ToString().PadLeft(4));
					}

					// display the multiplication result
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write((verticalItems[j] * horizontalItems[i]).ToString().PadLeft(4));
					Console.ForegroundColor = ConsoleColor.White;
				}

				// break the line after the last item in a row
				Console.WriteLine();


			}

		}
	}
}   
