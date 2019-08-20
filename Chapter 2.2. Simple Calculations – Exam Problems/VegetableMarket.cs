using System;

class MainClass {
	public static void Main (string[] args)
	{
		Console.Write("First fruit price = ");
		double price1 = double.Parse(Console.ReadLine());
		
		Console.Write("Second fruit price = ");
		double price2 = double.Parse(Console.ReadLine());

		Console.Write("First fruit quantity = ");
		int q1 = int.Parse(Console.ReadLine());

		Console.Write("Second fruit quantity = ");
		int q2 = int.Parse(Console.ReadLine());

		double result = ((price1*q1) + (price2*q2)) / 1.94;
		Console.WriteLine($"Total = {result} EUR");
	}
}