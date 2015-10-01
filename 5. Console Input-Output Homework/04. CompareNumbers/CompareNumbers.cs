using System;

	class CompareNumbers
	{
		static void Main()
		{
			Console.Write("Input a: ");
			double a = double.Parse(Console.ReadLine());

			Console.Write("Input b: ");
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("Greater: " + Math.Max(a, b));
		}
	}