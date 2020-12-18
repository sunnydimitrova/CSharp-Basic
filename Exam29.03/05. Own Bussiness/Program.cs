using System;

namespace _05._Own_Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int area = w * l * h;
            int freeSpace = area;
            while (freeSpace > 0)
            {
                if (input == "Done")
                {
                    break;
                }
                int computers = int.Parse(input);
                freeSpace -= computers;
                input = Console.ReadLine();
            }
            if (freeSpace >= 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
