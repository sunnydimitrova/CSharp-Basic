using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                sum += number;
            }
            sum -= maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNumber)}");
            }
        }
    }
}
