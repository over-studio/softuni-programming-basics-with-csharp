using System;

class MainClass
{
	public static void Main (string[] args)
	{
    	Console.WriteLine ("Speed Assessment");

		Console.Write("Enter a speed : ");
		double speed = double.Parse(Console.ReadLine());

		if(speed > 1000)
			Console.WriteLine("extremely fast");
		else if(speed > 150)
			Console.WriteLine("ultra fast");
		else if(speed > 50)
			Console.WriteLine("fast");
		else if(speed > 10)
			Console.WriteLine("average");
		else
			Console.WriteLine("slow");
	}
}