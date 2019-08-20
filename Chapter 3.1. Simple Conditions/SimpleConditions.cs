using System;

class MainClass {
	public static void Main (string[] args) {
		double grade = double.Parse(Console.ReadLine());

		if(grade >= 5.50)
		{
			Console.WriteLine ("Excellent!");
		}
		else
		{
			Console.WriteLine("Not Excellent.");
		}

		if(grade % 2 == 0)
		{
			Console.WriteLine("Even");
		}
		else
		{
			Console.WriteLine("Odd");
		}
	}
}