using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int minNumber = int.MaxValue;
            while (counter < n)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }
                counter++;
            }
            Console.WriteLine(minNumber);
        }
    }
}
