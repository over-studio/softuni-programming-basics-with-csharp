using System;

class MainClass
{
	public static void Main (string[] args)
	{
		const string correctPWD = "s3cr3t!P@ssw0rd";

		Console.Write("Enter password : ");
		string pwd = Console.ReadLine();

		if(pwd == correctPWD)
		{
			Console.WriteLine("Welcome");
		}
		else
		{
			Console.WriteLine("Wrong password!");
		}
	}
}