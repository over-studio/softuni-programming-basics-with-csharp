using System;

class MainClass
{
	public static void Main (string[] args)
	{
		int s1 = 50;
		int s2 = 50;
		int s3 = 50;

		int total = s1 + s2 + s3;

		int min = total / 60;
		int sec = total % 60;

		Console.Write(min + ":");

		if(sec < 10)
			Console.Write("0");
		
		Console.Write(sec);
	}
}