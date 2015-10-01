using System;

	class Trapezoid
	{
		static void Main()
		{
			Console.Write("a = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("h = ");
			double h = double.Parse(Console.ReadLine());

			double area = ((a + b) / 2) * h;

			Console.WriteLine("The area of a trapezoid with sides a = {0}, {1} and a height of {2} is {3} square cm", a, b, h, area);
		}
	}