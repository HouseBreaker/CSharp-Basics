using System;

class SortThree
{
	static void Main()
	{
		Console.WriteLine("Please enter 3 real numbers");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());

		Console.WriteLine();
		if (a > b && a > c)
		{
			Console.Write(a + " ");

			if (b > c)
			{
				Console.WriteLine(b + " " + c);
			}
			else
			{
				Console.WriteLine(c + " " + b);
			}
		}
		else if (b > a && b > c)
		{
			Console.Write(b + " ");
			if (a > c)
			{
				Console.WriteLine(a + " " + c);
			}
			else
			{
				Console.WriteLine(c + " " + a);
			}
		}
		else if (c > a && c > b)
		{
			Console.Write(c + " ");
			if (a > b)
			{
				Console.WriteLine(a + " " + b);
			}
			else
			{
				Console.WriteLine(b + " " + a);
			}
		}
	}
}
