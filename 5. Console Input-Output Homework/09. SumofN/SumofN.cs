using System;

class SumofN
{
	static void Main()
	{
		Console.Write("Please enter a number: ");
		int n = int.Parse(Console.ReadLine());
		int m;
		int sum = 0;
		Console.WriteLine("\nPlease enter {0} more numbers: ", n);
		Console.WriteLine();
		for (int i = 1; i <= n; i++)
		{
			m = int.Parse(Console.ReadLine());
			sum += m;
		}

		Console.WriteLine("sum: {0}", sum);
	}
}