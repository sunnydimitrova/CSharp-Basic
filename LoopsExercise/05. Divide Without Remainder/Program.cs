﻿using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;           
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
        }
    }
}
