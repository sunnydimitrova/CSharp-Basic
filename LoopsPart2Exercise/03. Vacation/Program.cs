using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoneyForVacantion = double.Parse(Console.ReadLine());
            double amountAvailable = double.Parse(Console.ReadLine());
            double savedMoney = amountAvailable;
            int spendCounter = 5;
            int daysCounter = 0;
            while (savedMoney < needMoneyForVacantion)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (input == "save")
                {
                    savedMoney += money;
                    spendCounter = 5;
                }
                else
                {
                    savedMoney -= money;
                    spendCounter--;
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                }
                if (spendCounter < 1)
                {
                    break;
                }
            }
            if (spendCounter < 1)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}
