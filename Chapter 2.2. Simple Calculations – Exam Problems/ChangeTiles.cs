using System;

class MainClass {
	public static void Main (string[] args)
	{
		/*
		Write a program that reads the size of the ground, 
		the tiles and the bench from the console, 
		and calculates how many tiles are needed to cover 
		the ground and what is the total time for replacing the tiles.
		*/

		// input
		int groundSide = 20;
		double tileWidth = 5;
		double tileHeight = 4;
		int benchWidth = 1;
		int benchHeight = 2;

		// output
		double tilesNumber = (groundSide * groundSide - benchWidth * benchHeight) / (tileWidth * tileHeight);

		double timeReplaceTiles = tilesNumber * 0.2;

		Console.WriteLine($"Tiles needed = {tilesNumber}");
		Console.WriteLine($"Time needed = {timeReplaceTiles}");
	}
}