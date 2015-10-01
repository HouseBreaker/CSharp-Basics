using System;

	class Circle
	{
		static void Main()
		{
			Console.Write("Enter the X coordinate: ");
			double x = double.Parse(Console.ReadLine());
			Console.Write("\nEnter the Y coordinate: ");
			double y = double.Parse(Console.ReadLine());
			int radius = 2;

			if ((x * x + y * y) <= (radius * radius))
			{
				Console.WriteLine("\nThe point with coordinates ({0}, {1}) is inside the circle!", x, y);
			}
			else
			{
				Console.WriteLine("\nThe point with coordinates ({0}, {1}) is NOT inside the circle!", x, y);
			}
		}
	}