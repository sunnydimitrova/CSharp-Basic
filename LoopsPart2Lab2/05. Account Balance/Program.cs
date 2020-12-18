using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            while (counter < n)
            {
                double installment = double.Parse(Console.ReadLine());
                if (installment > 0)
                {
                    Console.WriteLine($"Increase: {installment:f2}");
                    sum += installment;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                counter++;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
