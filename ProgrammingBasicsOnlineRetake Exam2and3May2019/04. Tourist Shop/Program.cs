using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spendMoney = 0;
            int productCounter = 0;
            while (budget >= spendMoney)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                productCounter++;
                if (productCounter % 3 == 0)
                {
                    price = price / 2;
                }
                spendMoney += price;
            }
            if (budget >= spendMoney)
            {
                Console.WriteLine($"You bought {productCounter} products for {spendMoney:f2} leva.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {spendMoney - budget:f2} leva!");
            }
        }
    }
}
