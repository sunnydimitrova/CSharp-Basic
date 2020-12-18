using System;

namespace Exam29._03
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuelLiters = double.Parse(Console.ReadLine());
            double timeSum = Math.Ceiling((2.0 * 384400) / speed);
            double finalTime = timeSum + 3;
            double sumOfLitersFuel = (fuelLiters * (2.0 * 384400)) / 100;
            Console.WriteLine(finalTime);
            Console.WriteLine(sumOfLitersFuel);
        }
    }
}
