using System;

	class Rectangles
	{
		static void Main()
		{
			Console.Write("Width: ");
			double w = double.Parse(Console.ReadLine());
			Console.Write("Height: ");
			double h = double.Parse(Console.ReadLine());
			
			double P = 2*(w + h);
			double S= w * h;

			Console.WriteLine("Perimeter = {0}, Area = {1}", P, S);

			
		}
	}
