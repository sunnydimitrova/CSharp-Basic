using System;

namespace _07._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardMeters = double.Parse(Console.ReadLine());
            double sum = yardMeters * 7.61;
            double discount = sum * 18 / 100;
            double finalPraise = sum - discount;
            Console.WriteLine($"The final price is: {finalPraise:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
