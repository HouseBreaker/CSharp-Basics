using System;
using System.Linq;

	class MinMaxSumAverage
	{
		static void Main()
		{
			int n;
			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Invalid input, please try again");
			}

			Console.WriteLine();

			int[] array = new int[n];

			for (int i = 0; i < n; i++)
			{
				Console.Write(i+1 + " = ");
				array[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine();

			Console.WriteLine("Minimum = " + array.Min());
			Console.WriteLine("Maximum = " + array.Max());
			Console.WriteLine("Sum = " + array.Sum());
			Console.WriteLine("Average = {0:F2}", Convert.ToDouble(array.Average()));

			
		}
	}
