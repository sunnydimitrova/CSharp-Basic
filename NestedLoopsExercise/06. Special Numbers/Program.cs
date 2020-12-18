using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int specialNumber = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                specialNumber = i;
                while (specialNumber > 0)
                {
                    int digit = specialNumber % 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else
                    {
                        isSpecial = true;
                    }
                    
                    specialNumber /= 10;
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
