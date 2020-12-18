using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double rest = coins * 100;
            int counterMonets = 0;
            while (rest >= 1)
            {
                counterMonets++;
                if (rest >= 200)
                {
                    rest -= 200;
                }
               else if (rest >= 100)
                {
                    rest -= 100;
                }
                else if (rest >= 50)
                {
                    rest -= 50;
                }
                else if (rest >= 20)
                {
                    rest -= 20;
                }
                else if (rest >= 10)
                {
                    rest -= 10;
                }
                else if (rest >= 5)
                {
                    rest -= 5;
                }
                else if (rest >= 2)
                {
                    rest -= 2;
                }
                else if (rest >= 1)
                {
                    rest -= 1;
                }
            }
            Console.WriteLine($"{counterMonets}");
        }
    }
}
