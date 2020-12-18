using System;

namespace Pin2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            for (int i = 2; i <= first; i++)
            {
                for (int j = 2; j <= second; j++)
                {

                    for (int k = 2; k <= third; k++)
                    {
                        if (i % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7) && k % 2 == 0)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
