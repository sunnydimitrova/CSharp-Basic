using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int number = i;
                int variable = number;
                bool isTrue = true;
                int evenSum = 0;
                int oddSum = 0;
                while (variable > 0)
                {
                    int digit = variable % 10;
                    variable = variable / 10;
                    if (isTrue)
                    {
                        evenSum += digit;
                        isTrue = false;
                    }
                    else
                    {
                        oddSum += digit;
                        isTrue = true;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
