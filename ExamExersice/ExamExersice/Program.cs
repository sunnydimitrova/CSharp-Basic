using System;

namespace ExamExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinsPrice = double.Parse(Console.ReadLine());
            double theCalfKG = double.Parse(Console.ReadLine());
            double candyKG = double.Parse(Console.ReadLine());
            double biscuitsKG = double.Parse(Console.ReadLine());
            double theCalfPrice = baklavaPrice + (baklavaPrice * 60 / 100);
            double candyPrice = muffinsPrice + (muffinsPrice * 80 / 100);
            double sum = (theCalfKG * theCalfPrice) + (candyKG * candyPrice) + (biscuitsKG * 7.50);
            Console.WriteLine($"{sum:f2}");

        }
    }
}
