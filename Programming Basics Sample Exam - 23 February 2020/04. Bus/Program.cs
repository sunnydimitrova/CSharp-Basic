using System;

namespace _04._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPasenger = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int sumOfPasengers = numberOfPasenger;
            for (int i = 1; i <= n; i++)
            {
                int pasengerOut = int.Parse(Console.ReadLine());
                int pasengerCome = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOfPasengers = (sumOfPasengers - pasengerOut - 2) + pasengerCome;
                }
                else
                {
                    sumOfPasengers = (sumOfPasengers - pasengerOut) + pasengerCome + 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {sumOfPasengers}");
        }
    }
}
