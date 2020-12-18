using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input = Console.ReadLine();
            while (input != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                sum = 0;
                while (sum < moneyNeeded)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
            }
        }
    }
}
