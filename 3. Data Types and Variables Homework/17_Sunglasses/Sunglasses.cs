using System;

class Sunglasses
{
	static void Main()
	{

		int num = int.Parse(Console.ReadLine());
		string top = "";
		string mid = "";
		string midframe = "";
		
		//Top and bottom
		top = new string('*', num * 2);
		top += new string(' ', num);
		top += new string('*', num * 2);

		//middle
		mid = "*";
		mid += new string('/', num * 2 - 2);
		mid += "*";
		mid += new string (' ', num);
		mid += "*";
		mid += new string('/', num * 2 - 2);
		mid += "*";

		midframe = "*";
		midframe += new string('/', num * 2 - 2);
		midframe += "*";
		midframe += new string('|', num);
		midframe += "*";
		midframe += new string('/', num * 2 - 2);
		midframe += "*";

		Console.WriteLine(top);
		for (int i = 0; i < num-2; i++)
		{
			if (i==num/2-1)
			{
				Console.WriteLine(midframe);
			}
			else
			{
				Console.WriteLine(mid);
			}
			
		}
		Console.WriteLine(top);


	}
}