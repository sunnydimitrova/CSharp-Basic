using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersOfFuel = double.Parse(Console.ReadLine());
            string dayOfWeekend = Console.ReadLine();
            double priceWhithoutDiscound = (litersOfFuel * 2.10) + 100;
            double finalPrice = 0;
            if (dayOfWeekend == "Saturday")
            {
                 finalPrice = priceWhithoutDiscound * 0.9;
            }
            else if (dayOfWeekend == "Sunday")
            {
                finalPrice = priceWhithoutDiscound * 0.8;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - finalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {finalPrice - budget:f2} lv.");
            }
        }
    }
}
