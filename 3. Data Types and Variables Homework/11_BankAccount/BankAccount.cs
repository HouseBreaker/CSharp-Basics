using System;

class BankAccount
{
	static void Main()
	{
		string FirstName;
		string MiddleName;
		string LastName;
		string IBAN;
		long credit1;
		long credit2;
		long credit3;
		float balance;
		string currency;

		FirstName = "John";
		MiddleName = "West";
		LastName = "Smith";
		IBAN = "BG80 BNBG 9661 1020 3456 78";
		credit1 = 378282246310005;
		credit2 = 371449635398431;
		credit3 = 378734493671000;
		balance = 4236.76F;
		currency = "USD";

		Console.WriteLine("Name: {0} {1} {2}\n", FirstName, MiddleName, LastName);
		Console.WriteLine("IBAN: {0}\n", IBAN);
		Console.WriteLine("Credit Card Numbers:\n1: {0}\n2: {1}\n3: {2}\n", credit1, credit2, credit3);
		Console.WriteLine("Current Balance: {0} {1}", balance, currency);
	}
}
