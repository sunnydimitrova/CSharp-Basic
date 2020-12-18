using System;

namespace Programming_Basics_Online_Exam___9_and_10_March_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneYearsPrice = int.Parse(Console.ReadLine());
            double shooesPrice = oneYearsPrice * 0.60;
            double clotes = shooesPrice * 0.80;
            double ballPrice = clotes * 1 / 4.0;
            double things = ballPrice * 1 / 5.0;
            double sum = shooesPrice + clotes + ballPrice + things + oneYearsPrice;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
