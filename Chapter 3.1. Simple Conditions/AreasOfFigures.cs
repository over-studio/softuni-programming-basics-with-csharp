using System;

class MainClass
{
	public static void Main (string[] args)
	{
    	Console.WriteLine ("Areas of figures");

		Console.Write("Enter the type of the shape : ");
		string shape = Console.ReadLine().ToLower();

		if(shape == "triangle")
		{
			Console.Write("Enter side : ");
			double side = double.Parse(Console.ReadLine());
			Console.Write("Enter height : ");
			double height = double.Parse(Console.ReadLine());
			Console.WriteLine("Area = " + (side*height/2));
		}
		else if(shape == "square")
		{
			Console.Write("Enter cote : ");
			double cote = double.Parse(Console.ReadLine());
			Console.WriteLine("Area = " + (cote*cote));
		}
		else if(shape == "rectangle")
		{
			Console.Write("Enter width : ");
			double width = double.Parse(Console.ReadLine());
			Console.Write("Enter height : ");
			double height = double.Parse(Console.ReadLine());
			Console.WriteLine("Area = " + (width*height));
		}
		else if(shape == "circle")
		{
			Console.Write("Enter radius : ");
			double radius = double.Parse(Console.ReadLine());
			Console.WriteLine("Area = " + (Math.PI*radius*radius));
		}
	}
}