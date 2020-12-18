using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inrange = (num >= 100 && num <= 200) || num == 0;
            if(!inrange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
