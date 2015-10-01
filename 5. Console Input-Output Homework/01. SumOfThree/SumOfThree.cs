using System;

class SumOfThree
{
	static void Main()
	{
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());

		Console.WriteLine("The Sum of {0}, {1}, and {2} is {3}", a, b, c, (a + b + c));
	}
}