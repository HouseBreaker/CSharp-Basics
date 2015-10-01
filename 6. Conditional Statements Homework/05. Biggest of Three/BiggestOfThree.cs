using System;


	class BiggestOfThree
	{
		static void Main()
		{
			Console.WriteLine("Input a, b, c");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());

			Console.WriteLine("Biggest: " + Math.Max(a, Math.Max(b, c)));
		}
	}