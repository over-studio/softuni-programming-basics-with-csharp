using System;

class MainClass {
	public static void Main (string[] args) {
		Console.Write("Number of Bitcoins = ");
		int bitcoins = int.Parse(Console.ReadLine());

		Console.Write("Number of Chinese Yuans = ");
		double cheniseYuans = double.Parse(Console.ReadLine());

		Console.Write("Commission Fee = ");
		double commissionFee = double.Parse(Console.ReadLine()) / 100;

		double euro = (bitcoins * 1168 + cheniseYuans * 0.15 * 1.76) / 1.95;
		
		Console.WriteLine("Money earned = " + (euro - euro * commissionFee) + " EUR");
	}
}