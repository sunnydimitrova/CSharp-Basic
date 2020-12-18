using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstUperLimit = int.Parse(Console.ReadLine());
            int secondUperLimit = int.Parse(Console.ReadLine());
            int thirtUperLimit = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int first = 2; first <= firstUperLimit; first++)
            {
                if (first % 2 != 0)
                {
                    continue;
                }
                if (secondUperLimit > 7)
                {
                    secondUperLimit = 7;
                }
                for (int second = 2; second <= secondUperLimit; second++)
                {
                    for (int i = 2; i <= Math.Sqrt(second); i++)
                    {
                        if (second % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }
                        if (isPrime == false)
                        {
                            continue;
                        }
                    for (int thirt = 2; thirt <= thirtUperLimit; thirt++)
                    {
                        if (thirt % 2 == 0)
                        {
                            Console.WriteLine($"{first} {second} {thirt}");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
