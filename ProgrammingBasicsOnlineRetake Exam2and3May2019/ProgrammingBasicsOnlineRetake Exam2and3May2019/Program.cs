using System;

namespace ProgrammingBasicsOnlineRetake_Exam2and3May2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChikenMenu = int.Parse(Console.ReadLine());
            int numberOfFishMenu = int.Parse(Console.ReadLine());
            int nuumberOfVegetarianMenu = int.Parse(Console.ReadLine());
            double sumOfFoodBeforDesert = (numberOfChikenMenu * 10.35) + (numberOfFishMenu * 12.40) + (nuumberOfVegetarianMenu * 8.15);
            double sumForDesert = sumOfFoodBeforDesert * 0.20;
            double finalPrice = sumOfFoodBeforDesert + sumForDesert + 2.50;
            Console.WriteLine($"Total {finalPrice:f2}");
        }
    }
}
