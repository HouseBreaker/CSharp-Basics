using System;

class BinaryToDec
{
	static void Main()
	{
		Console.Write("Please enter a binary number: ");
		string input = Console.ReadLine();
		long output = 0;

		for (int i = 0; i < input.Length; i++)
		{
			output = output*2 + (input[i]-48);
			//Console.WriteLine(output + " * 2 + " + input[i] + " = " + output);
		}
		Console.WriteLine("Decimal representation: "+ output);
	}

	//static int powerof(int input, int up)
	//{
	//	int initial = input;
	//	for (int i = 1; i < up; i++)
	//	{
	//			input*=initial;
	//	}
	//	return input;
	//}
}