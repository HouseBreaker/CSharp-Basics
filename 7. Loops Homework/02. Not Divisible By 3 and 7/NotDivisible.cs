using System;


	class NotDivisible
	{
		static void Main()
		{
			Console.WriteLine("Please enter a positive integer: ");
			int n;

			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Invalid input! Try again!");
			}

			for (int i = 1; i <= n; i++)
			{
				if (!(i % 3 == 0) && !(i % 7 == 0))
				{
					Console.Write(i + " ");
				}
			}
			Console.WriteLine();
		}
	}
