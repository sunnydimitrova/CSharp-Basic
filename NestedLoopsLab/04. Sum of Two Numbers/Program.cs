using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = 0;
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    counter++;
                    result = i + j;
                    if (result == c)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {result})");
                        break;
                    }
                }
                if (result == c)
                {
                    break;
                }
            }
            if (c != result)
            {
                Console.WriteLine($"{counter} combinations - neither equals {c}");
            }
        }
    }
}
