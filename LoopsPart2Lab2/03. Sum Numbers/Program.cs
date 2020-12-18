using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "Stop")
            {
                int inputAssNumber = int.Parse(input);
                sum += inputAssNumber;
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
