using System;


class Exchange
{
	static void Main()
	{
		Console.WriteLine("Please enter two numbers.");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());

		if (b > a)
		{
			Console.WriteLine(a + " " + b);
		}
		else
		{
			Console.WriteLine(b + " " + a);
		}
	}
}