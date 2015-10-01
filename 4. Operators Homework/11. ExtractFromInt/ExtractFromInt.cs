using System;

class ExtractFromInt
{
	static void Main()
	{
		Console.Write("Enter n: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Enter index: ");
		int p = int.Parse(Console.ReadLine());
		Console.WriteLine("Bit position {0} in {1} is {2}", p, n, ((n >> p) & 1));
	}
}
