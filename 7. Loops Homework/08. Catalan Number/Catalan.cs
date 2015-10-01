using System;
using System.Numerics;

static class Catalan
{
	static void Main()
	{
		Console.WriteLine("Please input n:");
		int n = 0;
			n = Check(n);
		
		BigInteger output = (factorial(2*n) / (factorial(n+1)*factorial(n)));
		Console.WriteLine("Catalan number for " + n + " = " + output);
	}

	static BigInteger factorial(this BigInteger result)
	{
		for (int i = (int)result-1; i > 0; i--)
		{
			result *= i;
		}
		return result;
	}

	static int Check(this int check)
	{
		while (!int.TryParse(Console.ReadLine(), out check))
		{
			Console.WriteLine("Incorrect input, try again.");
		}
		return check;
	}
}
