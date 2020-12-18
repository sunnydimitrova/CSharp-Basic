using System;

namespace _06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumOfMoney = 0;
            double sumOfMoneyForDay = 0;
            for (int i = 1; i <= days; i++)
            {
                sumOfMoneyForDay = 0;
                for (int f = 1; f <= hours; f++)
                {
                    if (i % 2 == 0 && f % 2 != 0)
                    {
                        sumOfMoneyForDay += 2.50;
                    }
                    else if (i % 2 != 0 && f % 2 == 0)
                    {
                        sumOfMoneyForDay += 1.25;
                    }
                    else
                    {
                        sumOfMoneyForDay += 1.00;
                    }
                }
                sumOfMoney += sumOfMoneyForDay;
                Console.WriteLine($"Day: {i} - {sumOfMoneyForDay:f2} leva");
            }
            Console.WriteLine($"Total: {sumOfMoney:f2} leva");
        }
    }
}
