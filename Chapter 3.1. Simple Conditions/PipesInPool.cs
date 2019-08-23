using System;

class MainClass
{
	public static void Main (string[] args)
	{
		//Console.WriteLine ("Pipes in pool");

		//Console.Write("Volume of the pool = ");
		//int poolVolume = int.Parse(Console.ReadLine());
		int poolVolume = 1000;

		//Console.Write("Flow rate of the first pipe per hour = ");
		//int rate1 = int.Parse(Console.ReadLine());
		int rate1 = 100;

		//Console.Write("Flow rate of the second pipe per hour = ");
		//int rate2 = int.Parse(Console.ReadLine());
		int rate2 = 120;

		//Console.Write("Absence hours = ");
		//int absence = int.Parse(Console.ReadLine());
		double absence = 3;

		double totalWater1 = rate1 * absence;
		double totalWater2 = rate2 * absence;
		double totalWater = totalWater1 + totalWater2;
		if(totalWater <= poolVolume)
		{
			double percent1 = Math.Truncate(totalWater1 * 100 / totalWater);
			double percent2 = Math.Truncate(totalWater2 * 100 / totalWater);
			Console.WriteLine("The pool is [" + (totalWater * 100 / poolVolume) + "]% full. Pipe 1: [" + percent1 + "]%. Pipe 2: [" + percent2 + "]%.");
		}
		else
		{
			double over = totalWater1 + totalWater2 - poolVolume;
			Console.WriteLine("For [" + absence + "] hours the pool overflows with [" + over + "] liters.");
		}
	}
}