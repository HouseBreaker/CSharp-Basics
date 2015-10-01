using System;
using System.Linq;


static class Factorial
{
	static void Main()
	{
		Console.WriteLine("Please enter n and x:");

		int n = 0;
			n = CheckInput(n);

		int x = 0;
			x = CheckInput(x);

		double sum = 1;

		for (int i = 1; i <= n; i++)
		{
			sum += (FactorialCalc(i)) / (Math.Pow(x, i));
		}
		Console.WriteLine("{0:F5}", sum);
	}


	static int CheckInput(this int check)
	{
		while (!int.TryParse(Console.ReadLine(), out check))
		{
			Console.WriteLine("Invalid input. Please try again.");
		}
		return check;
	}

	static int FactorialCalc(this int count)
	{
		return count == 0
				   ? 1
				   : Enumerable.Range(1, count).Aggregate((i, j) => i * j);
	}
}
