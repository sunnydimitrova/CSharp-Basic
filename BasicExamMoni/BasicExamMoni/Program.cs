using System;

namespace BasicExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            for (int i = 1; i <= first; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                
                for (int j = 2; j <= second; j++)
                {
                    bool isPrime = true; 
                    for (int p = 2; p <= j / 2; p++)
                    {
                        if (j % p == 0)
                        {
                            isPrime = false;
                            break;
                        }                        
                    }
                    if (!isPrime)
                    {
                        continue;
                    }
                    for (int k = 1; k <= third; k++)
                    {
                        if (k % 2 == 0)
                        {
                            if (isPrime)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                            }
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
