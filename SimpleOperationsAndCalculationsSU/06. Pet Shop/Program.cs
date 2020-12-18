using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double sum = (dogs * 2.50) + (animals * 4.00);
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
