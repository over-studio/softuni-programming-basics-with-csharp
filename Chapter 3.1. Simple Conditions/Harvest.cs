using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harvest");

            Console.Write("vineyard Size (m2) = ");
            int vineyardSize = int.Parse(Console.ReadLine());
            Console.Write("grapes Per Meter square = ");
            double grapesPerMeter = double.Parse(Console.ReadLine());
            Console.Write("Needed liters of wine = ");
            int wineNeeded = int.Parse(Console.ReadLine());
            Console.Write("Number of workers = ");
            int workers = int.Parse(Console.ReadLine());

            /*
            If the produced wine is less than the needed quantity:
            “It will be a tough winter! More {insufficient wine} liters wine needed.”
            * The result has to be rounded down to the nearest integer.
            If the produced wine is more than the needed quantity:
            “Good harvest this year! Total wine: {total wine} liters.”
            * The result has to be rounded down to the nearest integer.
            “{Wine left} liters left -> {wine for one worker} liters per person.”
            * Both of the results have to be rounded up to the higher integer.
            */

            double wineProduced = vineyardSize * grapesPerMeter * 0.4 / 2.5;

            if (wineProduced < wineNeeded)
            {
                double insufficientWine = Math.Truncate(wineNeeded - wineProduced);
                Console.WriteLine($"It will be a tough winter! More {insufficientWine} liters wine needed.");
            }
            else
            {
                double wineLeft = Math.Truncate(wineProduced- wineNeeded);
                double wineLeftPerWorker = Math.Truncate(wineLeft / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {wineProduced} liters.\n{wineLeft} liters left -> {wineLeftPerWorker} liters per person.");
            }
        }
    }
}

