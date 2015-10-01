using System;

class From1toN
{
	static void Main()
	{
		int n;

		//input checking
		while (!int.TryParse(Console.ReadLine(), out n))
		{
			Console.WriteLine("Invalid input, try again.");
		}


		for (int i = 1; i < n; i++)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine(n);

	}
}
