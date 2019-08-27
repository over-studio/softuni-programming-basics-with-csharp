using System;

namespace FirmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firm Problem : ");

            Console.Write("Needed Hours = ");
            int neededHours = int.Parse(Console.ReadLine());

            Console.Write("Needed Days = ");
            int neededDays = int.Parse(Console.ReadLine());

            Console.Write("Number of Workers = ");
            int workers = int.Parse(Console.ReadLine());


            double hoursOfWorkInCompany = Math.Truncate(workers * 10 * neededDays * 0.9);

            if(neededHours < hoursOfWorkInCompany)
            {
                double hoursLeft = hoursOfWorkInCompany - neededHours;
                Console.WriteLine($"Yes! {hoursLeft} hours left.");
            }
            else {
                double additionalHours = neededHours - hoursOfWorkInCompany;
                Console.WriteLine($"Not enough time! {additionalHours} hours needed.");
            }
        }
    }
}
