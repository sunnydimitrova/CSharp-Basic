using System;

namespace Telerik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    for (int i = 2; i <= Math.Sqrt(col); i++)
                    {
                        if (col % i == 0)
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
                        Console.Write(col + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
