using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            double points = 0;
            if (number <= 100)
            {
                points = 5;                
            }
            else if (number <= 1000)
            {
                points = number * 20 / 100;
            }
            else
            {
                points = number * 10 / 100;
            }
            if (number % 2 == 0)
            {
                points = points + 1;
                Console.WriteLine(points);
                Console.WriteLine(number + points);
            }
            else if (number % 10 == 5)
            {
                points = points + 2;
                Console.WriteLine(points);
                Console.WriteLine(number + points);
            }
            else
            {
                Console.WriteLine(points);
                Console.WriteLine(number + points);
            }
        }
    }
}
