﻿using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPrime = true;
            int primeSum = 0;
            int notPrimeSum = 0;
            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    notPrimeSum += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }
    }
}
