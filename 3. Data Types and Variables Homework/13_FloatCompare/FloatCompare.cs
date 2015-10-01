using System;

class FloatCompare
{
	static void Main()
	{
		double a = 4.999999;
		double b = 4.999998;
		double eps = 0.000001;

		bool equal = Math.Abs(a - b) < eps;

		Console.Write("Is the number {0} equal to {1} with a precision of {2}?", a, b, String.Format("{0:0.######}", eps));
		if (equal) { Console.WriteLine(" Yes."); }
		else { Console.WriteLine(" No."); }

	}
}