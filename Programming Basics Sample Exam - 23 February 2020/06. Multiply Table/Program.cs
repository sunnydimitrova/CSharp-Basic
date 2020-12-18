using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int a = 0;
            int b = 0;
            int c = 0;
            
            while (number > 0)
            {
                a = number % 10;
                number = number / 10;
                b = number % 10;
                number = number / 10;
                c = number % 10;
                number = number / 10;              
            }
            for (int First = 1; First <= a; First++)
            {
                for (int second = 1; second <= b; second++)
                {
                    for (int thirt = 1; thirt <= c; thirt++)
                    {
                        int result = First * second * thirt;
                        Console.WriteLine($"{First} * {second} * {thirt} = {result};");
                    }
                }
            }
        }
    }
}
