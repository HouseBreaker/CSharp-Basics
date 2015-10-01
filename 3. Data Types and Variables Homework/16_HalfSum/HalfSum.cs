using System;
using System.Linq;

	class HalfSum
	{
		static void Main()
		{
			int num = int.Parse(Console.ReadLine());

			int[] numbers1;
			int[] numbers2;
			numbers1 = new int[num];
			numbers2 = new int[num];


			Console.WriteLine("Your number is {0}", num);

			for (int i = 0; i < num; i++)
			{
				numbers1[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine();

			for (int i = 0; i < num; i++)
			{
				numbers2[i] = int.Parse(Console.ReadLine());
			}

			if (numbers1.Sum() == numbers2.Sum())
			{
				Console.WriteLine("Yes, sum={0}", numbers1.Sum());
			}
			else
			{
				Console.WriteLine("No, diff={0}", numbers1.Sum()-numbers2.Sum());
			}
		}
	}