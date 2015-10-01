using System;
class IntDoubleString
{
	static void Main()
	{
		Console.WriteLine("Please choose a type");
		Console.WriteLine("1 -> double");
		Console.WriteLine("2 -> int");
		Console.WriteLine("3 -> string");

		int choice = int.Parse(Console.ReadLine());

		switch (choice)
		{
			default:
				Console.WriteLine("Invalid input, please try again!");

				break;

			case 1:
				Console.WriteLine("Please enter a double:");
				double theDouble = double.Parse(Console.ReadLine());
				theDouble += 1;
				Console.WriteLine(theDouble);

				break;

			case 2:
				Console.WriteLine("Please enter an int:");
				int theInt = int.Parse(Console.ReadLine());
				theInt += 1;
				Console.WriteLine(theInt);

				break;

			case 3:
				Console.WriteLine("Please enter a string:");

				string theString = Console.ReadLine();
				theString += "*";
				Console.WriteLine(theString);

				break;
		}
	}
}
