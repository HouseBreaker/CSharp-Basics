using System;
using System.Numerics;

static class Divided
{
	static void Main()
	{
		Console.WriteLine("Please enter n and k:");
		int n = 0;
		n = CheckInput(n);

		int k = 0;
		k = CheckInput(k);

		Console.WriteLine("{0}! / {1}! = {2}", n, k, (FactorialCalc(n)/FactorialCalc(k)));
	}

	static BigInteger FactorialCalc(this BigInteger result)
	{
		for (int i = (int)result - 1; i > 0; i--)
		{
			result *= i;
		}
		return result;
	}

	static int CheckInput(this int check)
	{
		while (!int.TryParse(Console.ReadLine(), out check))
		{
			Console.WriteLine("Invalid input. Try again.");
		}
		return check;
	}
}
