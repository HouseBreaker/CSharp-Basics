using System;

class FormattingNumbers
{
	static void Main()
	{
		Console.Write("Input a: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("Input b: ");
		float b = float.Parse(Console.ReadLine());

		Console.Write("Input c: ");
		float c = float.Parse(Console.ReadLine());

		Console.WriteLine("|{0, -10:X}|{1}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
	}
}