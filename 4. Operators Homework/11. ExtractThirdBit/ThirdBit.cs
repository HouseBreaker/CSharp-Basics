using System;

	class ThirdBit
	{
		static void Main()
		{
			Console.Write("Enter n: ");
			uint n = uint.Parse(Console.ReadLine());
			Console.WriteLine("The third bit of {0} is {1}", n, (n>>3 & 1));
		}
	}
