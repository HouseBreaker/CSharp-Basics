using System;
using System.Linq;

class DecToBinary
{
	static void Main()
	{
		Console.Write("Please enter a decimal number: ");
		int input = int.Parse(Console.ReadLine());
		string output = "";

		while (input >= 1)
		{
			if (input % 2 == 0)
			{
				output += "0";
			}
			else
			{
				output += "1";
			}
			input /= 2;
		}

		output = new string(output.Reverse().ToArray()); //because our output is the reverse of what we actually want
		Console.WriteLine("Binary representation: " + output);
	}
}
