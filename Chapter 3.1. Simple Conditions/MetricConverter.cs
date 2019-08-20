using System;

class MainClass
{
	public static void Main (string[] args)
	{
		Console.WriteLine ("Metric Converter");

		Console.Write("Number for converting : ");
		double nbre = double.Parse(Console.ReadLine());
		
		Console.Write("Input Unit : ");
		string inputUnit = Console.ReadLine().ToLower();
		
		Console.Write("Output Unit : ");
		string outputUnit = Console.ReadLine().ToLower();

		if(inputUnit == "mm"){
			nbre /= 1000;
		}else if(inputUnit == "cm"){
			nbre /= 100;
		}else if(inputUnit == "mi"){
			nbre /= 0.000621371192;
		}else if(inputUnit == "in"){
			nbre /= 39.3700787;
		}else if(inputUnit == "km"){
			nbre /= 0.001;
		}else if(inputUnit == "ft"){
			nbre /= 3.2808399;
		}else if(inputUnit == "yd"){
			nbre /= 1.0936133;
		}

		if(outputUnit == "mm"){
			nbre *= 1000;
		}else if(outputUnit == "cm"){
			nbre *= 100;
		}else if(outputUnit == "mi"){
			nbre *= 0.000621371192;
		}else if(outputUnit == "in"){
			nbre *= 39.3700787;
		}else if(outputUnit == "km"){
			nbre *= 0.001;
		}else if(outputUnit == "ft"){
			nbre *= 3.2808399;
		}else if(outputUnit == "yd"){
			nbre *= 1.0936133;
		}

		Console.WriteLine(nbre + " " + outputUnit);
	}
}