using System;

class Fibonacci
{
	static void Main()
	{
		Console.Write("Write a number to generate a Fibonacci sequence: ");
		int n = int.Parse(Console.ReadLine());

		double a = 0;
		double b = 1;

		Console.WriteLine();
		Console.WriteLine(0 + "\n" + 1);
		for (int i = 0; i < n - 2; i++)
		{
			double temp = a;
			a = b;
			b = temp + b;
			Console.WriteLine(b);
		}
	}
}