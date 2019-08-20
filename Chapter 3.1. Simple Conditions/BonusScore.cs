using System;

class MainClass {
	public static void Main (string[] args)
	{
		/*
		If the number is up to 100 including, bonus score is 5.
		If the number is larger than 100, bonus score is 20% of the number.
		If the number is larger than 1000, bonus score is 10% of the number.
		Additional bonus score (accrued separately from the previous ones):
		for even number -> + 1 p.
		for number, that ends with 5 -> + 2 p.
		*/

		Console.Write("Enter a number : ");
		int nbre = int.Parse(Console.ReadLine());

		double bonus = 0;

		

		if(nbre > 1000)
		{
			bonus += nbre * 0.1;
		}
		else if(nbre > 100)
		{
			bonus += nbre * 0.2;
		}
		else
		{
			bonus += 5;
		}

		if(nbre % 2 == 0)
		{
			bonus += 1;
		}

		if(nbre % 10 == 5)
		{
			bonus += 2;
		}

		Console.WriteLine("Bonus = " + bonus);
		Console.WriteLine("Points = " + (nbre + bonus));
	}
}