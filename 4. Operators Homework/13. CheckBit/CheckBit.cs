using System;

class ExtractFromInt
{
	static void Main()
	{
		Console.Write("Enter n: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Enter index: ");
		int p = int.Parse(Console.ReadLine());
		bool check = false;
		if (((n >> p) & 1) == 1)
		{
			check = true;
			Console.WriteLine("Bit position {0} in {1} is 1: {2}", p, n, check);
		}
		else
		{
			check = false;
			Console.WriteLine("Bit position {0} in {1} is 1: {2}", p, n, check);
		}
	}
}
