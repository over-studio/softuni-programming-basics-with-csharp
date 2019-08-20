using System;

class MainClass
{
	public static void Main (string[] args)
	{
		Console.WriteLine ("Identical Words");

		Console.Write("Enter first word : ");
		string firstWord = Console.ReadLine().ToLower();

		Console.Write("Enter second word : ");
		string secondWord = Console.ReadLine().ToLower();

		if(firstWord == secondWord)
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}