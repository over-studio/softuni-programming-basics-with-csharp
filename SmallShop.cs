using System;

class MainClass
{
	public static void Main (string[] args)
	{
		Console.WriteLine ("Small Shop");

		Console.Write("Enter the Product : ");
		string product = Console.ReadLine().ToLower();

		Console.Write("Enter the City : ");
		string city = Console.ReadLine().ToLower();

		Console.Write("Enter the Quantity : ");
		double quantity = double.Parse(Console.ReadLine());

		double price = 0;

		if(city == "sofia")
		{
			if(product == "coffee"){
				price = quantity * 0.50;
			}else if(product == "water"){
				price = quantity * 0.80;
			}else if(product == "beer"){
				price = quantity * 1.20;
			}else if(product == "sweets"){
				price = quantity * 1.45;
			}else if(product == "peanuts"){
				price = quantity * 1.60;
			}
		}
		else if(city == "plovdiv")
		{
			if(product == "coffee"){
				price = quantity * 0.40;
			}else if(product == "water"){
				price = quantity * 0.70;
			}else if(product == "beer"){
				price = quantity * 1.15;
			}else if(product == "sweets"){
				price = quantity * 1.30;
			}else if(product == "peanuts"){
				price = quantity * 1.50;
			}
		}
		else if(city == "varna")
		{
			if(product == "coffee"){
				price = quantity * 0.45;
			}else if(product == "water"){
				price = quantity * 0.70;
			}else if(product == "beer"){
				price = quantity * 1.10;
			}else if(product == "sweets"){
				price = quantity * 1.35;
			}else if(product == "peanuts"){
				price = quantity * 1.55;
			}
		}

		Console.WriteLine("Price = " + price);
	}
}