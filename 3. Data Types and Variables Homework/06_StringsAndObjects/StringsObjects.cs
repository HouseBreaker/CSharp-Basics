using System;

	class StringsObjects
	{
		static void Main()
		{
			string a = "Hello";
			string b = "World";
			object thing = a + " " + b;
			
			string end = (string)thing;

			Console.WriteLine(end);
		}
	}