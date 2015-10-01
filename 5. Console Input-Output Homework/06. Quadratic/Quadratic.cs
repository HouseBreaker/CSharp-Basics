using System;
using System.Text;

class Quadratic
{
	static void Main()
	{
		Console.OutputEncoding = Encoding.UTF8;
		Console.Write("Input a: ");
		double a = double.Parse(Console.ReadLine());
		Console.Write("Input b: ");
		double b = double.Parse(Console.ReadLine());
		Console.Write("Input c: ");
		double c = double.Parse(Console.ReadLine());

		double D = b * b - 4 * a * c;
		double x1, x2;

		Console.WriteLine();

		if (D < 0)
		{
			Console.WriteLine("No real roots");
		}
		else if (D > 0)
		{
			x1 = (-b - Math.Sqrt(D)) / (2 * a);
			x2 = (-b + Math.Sqrt(D)) / (2 * a);

			Console.WriteLine("x₁ = {0}; x₂ = {1}", x1, x2);
		}
		else if (D == 0)
		{
			Console.WriteLine("x₁ = x₂ = {0}", (-b) / (2 * a));
		}
	}
}