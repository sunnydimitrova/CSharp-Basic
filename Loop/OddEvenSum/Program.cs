using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var odd = 0;
            var even = 0;
            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    even += element;
                }
                else
                {
                    odd += element;
                }
                if (odd == even)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = {0}", even);
                }
                else
                {
                    var diff = Math.Abs(odd - even);
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = {0}", diff);
                }
            }
        }
    }
}
