using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int mounts = int.Parse(Console.ReadLine());
            double outcome = double.Parse(Console.ReadLine());
            double unexpectedCosts = income * 0.30;
            double savedMonyForMounth = income - (outcome + unexpectedCosts);
            Console.WriteLine($"She can save {(savedMonyForMounth / income) * 100:f2}%");
            Console.WriteLine($"{savedMonyForMounth * mounts:f2}");
        }
    }
}
