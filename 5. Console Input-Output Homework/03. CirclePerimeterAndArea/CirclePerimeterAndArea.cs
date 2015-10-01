using System;


class Program
{
	static void Main()
	{
		double r = double.Parse(Console.ReadLine());
		double perimeter;
		double area;

		perimeter = 2 * Math.PI * r;
		area = Math.PI * (r * r);


		Console.WriteLine("Perimeter = {0:0.00}, Area = {1:0.00}", perimeter, area);
	}
}