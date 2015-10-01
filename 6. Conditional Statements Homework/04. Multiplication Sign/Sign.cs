using System;


class Sign
{
	static void Main()
	{
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());

		Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);
		


		if (a == 0 || b == 0 || c == 0)
		{
			Console.WriteLine("it's 0");
		}
		else if (((a < 0 && c < 0) || (a < 0 && b < 0) || (b < 0 && c < 0)) /*2 minuses*/
			   || (a > 0 && b > 0 && c > 0)) /*positive*/
		{
			Console.WriteLine("it's +");
		}
		else
		{
			Console.WriteLine("it's -");
		}
	}
}
