using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = minimalSalary * 0.35;
            double greatSuccessSchoparship = averageSuccess * 25;
            if (income < minimalSalary && averageSuccess >= 4.50  && averageSuccess < 5.50)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN" , Math.Floor(socialScholarship));
            }
            else if (averageSuccess >= 5.50 && income >= minimalSalary)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN" , Math.Floor(greatSuccessSchoparship));
            }
            else if (averageSuccess >= 5.50 && income < minimalSalary)
            {
                if (socialScholarship > greatSuccessSchoparship)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN" , Math.Floor(socialScholarship));
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(greatSuccessSchoparship));
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
