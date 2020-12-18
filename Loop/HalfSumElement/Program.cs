using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    number = max;
                }
                sum = sum - max;
            }
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                var diff = Math.Abs(max - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
