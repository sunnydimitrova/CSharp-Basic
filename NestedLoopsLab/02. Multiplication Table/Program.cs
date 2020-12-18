using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    result = a * b;
                    Console.WriteLine($"{a} * {b} = {result}");
                }
            }
        }
    }
}
