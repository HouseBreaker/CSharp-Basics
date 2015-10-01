using System;

class Matrix
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		int start = 1;
		for (int i = 1; i <= n; i++)
		{
			for (int j = start; j < n+start; j++)
			{
				Console.Write(j + " ");
			}
			Console.WriteLine();
			start++;
		}
		
	}
}
