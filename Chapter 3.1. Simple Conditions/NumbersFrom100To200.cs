using System;

class MainClass {
	public static void Main (string[] args)
	{
		Console.WriteLine ("Numbers from 100 to 200");

		Console.Write("Enter a number between 100 and 200 : ");
		int nbre = int.Parse(Console.ReadLine());

		if(nbre < 100){
			Console.WriteLine("Less than 100");
		}else if(nbre > 200){
			Console.WriteLine("Greater than 200");
		}else{
			Console.WriteLine("Between 100 and 200");
		}
	}
}