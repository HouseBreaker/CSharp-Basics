using System;
using System.Numerics;

//n! / (k! * (n-k)!)
static class Program
{
	static void Main()
	{
		Console.WriteLine("Please enter n and k:");
		int n = 0;
		n = Check(n);
		int k = 0;
		k = Check(k);

		BigInteger combinations = FactorialCalc(n) / (FactorialCalc(k) * (FactorialCalc(n - k)));
		Console.WriteLine("Possible combinations: {0}", combinations);
	}

	static int Check(this int check)
	{
		while (!int.TryParse(Console.ReadLine(), out check))
		{
			Console.WriteLine("Incorrect input, try again.");
		}
		return check;
	}

	static BigInteger FactorialCalc(this BigInteger result)
	{
		for (int i = (int)result - 1; i > 0; i--)
		{
			result *= i;
		}
		return result;
	}

}