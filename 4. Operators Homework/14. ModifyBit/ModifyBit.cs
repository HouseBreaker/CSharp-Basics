using System;

class ModifyBit
{
	static void Main()
	{
		Console.Write("Enter n: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Enter index: ");
		int p = int.Parse(Console.ReadLine());
		Console.Write("Enter value: ");
		int v = int.Parse(Console.ReadLine());

		int mask;
		int result;
		if (v == 1) 
		{
			mask = (1 << p);
			result = n | mask;
		}
		else
		{
			mask = ~(1 << p);
			result = n & mask;
		}
		
		string nbinary = Convert.ToString(n, 2).PadLeft(16, '0');
		string resultbinary = Convert.ToString(result, 2).PadLeft(16, '0');
		
		Console.WriteLine("Original value: {0}: {1}", n, nbinary);
		Console.WriteLine("Modified value: {0}, {1}", result, resultbinary);
	}
}
