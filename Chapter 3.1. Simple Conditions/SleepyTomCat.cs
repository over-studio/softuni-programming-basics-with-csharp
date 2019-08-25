using System;

class MainClass
{
	public static void Main (string[] args)
	{
		const int NORM_FOR_GAMES = 30000;

		Console.WriteLine ("Sleepy Tom Cat");

		Console.Write("Enter the working days : ");
		int workDays = int.Parse(Console.ReadLine());

		int timesForGames = (365-workDays)*63 + workDays*127;
		int diff = Math.Abs(timesForGames - NORM_FOR_GAMES);
		int hours = diff / 60;
		int minutes = diff % 60;

		if(timesForGames > NORM_FOR_GAMES)
		{
			Console.WriteLine("Tom will run away");
			Console.WriteLine(hours + " hours and " + minutes + " minutes more for play");
		}
		else
		{
			Console.WriteLine("Tom sleeps well");
			Console.WriteLine(hours + " hours and " + minutes + " minutes less for play");
		}
	}
}