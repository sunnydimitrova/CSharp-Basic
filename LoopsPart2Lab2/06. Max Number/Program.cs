using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxNumber = int.MinValue;
            while (counter < n)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                counter++;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
