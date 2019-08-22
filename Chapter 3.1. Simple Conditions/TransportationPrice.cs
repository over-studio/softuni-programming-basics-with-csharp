using System;

class MainClass {
	public static void Main (string[] args)
	{
		/*
		Taxi. Starting fee: 0.70 EUR. Day rate: 0.79 EUR/km. Night rate: 0.90 EUR/km.
		Bus. Day / Night rate: 0.09 EUR/km. Can be used for distances of minimum 20 km.
		Train. Day / Night rate: 0.06 EUR/km. Can be used for distances of minimum 100 km.
		
		Write a program that reads the number of kilometers n and period of the day (day or night) and calculates the price for the cheapest transport.
		*/

    	Console.WriteLine ("Transportation Price");

		Console.Write("Enter KM : ");
		double km = double.Parse(Console.ReadLine());

		Console.Write("Enter period of the day (day or night) : "); // 
		string period = Console.ReadLine().ToLower();
		
		double price = 0.70 + (period == "day" ? 0.79 : 0.90) * km;
		
		if(km >= 20)
		{
			double busPrice = 0.09 * km;
			if(busPrice < price)
			{
				price = busPrice;
			}
		}
		
		if(km >= 100)
		{
			double trainPrice = 0.06 * km;
			if(trainPrice < price)
			{
				price = trainPrice;
			}
		}

		Console.WriteLine("The cheapest price is : " + price);
	}
}