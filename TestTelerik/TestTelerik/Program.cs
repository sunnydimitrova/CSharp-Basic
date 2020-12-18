using System;
using System.Collections.Generic;

namespace TestTelerik
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            var sum = 0;
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                var number = input;
                var thirt = input % 10;
                input /= 10;
                var second = input % 10;
                input /= 10;
                var first = input % 10;
                input /= 10;
                if (first + thirt == second)
                {
                    sum += number;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
