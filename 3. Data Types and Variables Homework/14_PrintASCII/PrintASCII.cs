using System;

class PrintASCII
{
	static void Main()
	{
		for (int i = 0; i <= 255; i++)
		{
			if (i != 255)
			{
				Console.Write("{0}, ", Convert.ToChar(i));
			}
			else
			{
				Console.WriteLine(Convert.ToChar(i));
			}
			
		}
	}
}
