using System;

class SumofFive
{
	static void Main()
	{
		Console.WriteLine("Please enter 5 numbers:");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());
		double d = double.Parse(Console.ReadLine());
		double e = double.Parse(Console.ReadLine());

		Console.WriteLine("\nsum: {0}", a + b + c + d + e);
	}
}
