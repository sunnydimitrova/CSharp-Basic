using System;

namespace Programming_Basics_Sample_Exam___23_February_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForGifts = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());
            double litersGasoline = 420.0 / 100 * 7;
            double sumOfLiters = litersGasoline * 7;
            double moneyForGasoline = litersGasoline * 1.85;           
            double sumOfMoneyForHotel = (moneyForHotel * 0.9) + (moneyForHotel * 0.85) + (moneyForHotel * 0.8);            
            double moneyNeeded = sumOfMoneyForHotel + (3 * moneyForFood) + (3 * moneyForGifts) + moneyForGasoline;
            Console.WriteLine($"Money needed: {moneyNeeded:f2}");
        }
    }
}
