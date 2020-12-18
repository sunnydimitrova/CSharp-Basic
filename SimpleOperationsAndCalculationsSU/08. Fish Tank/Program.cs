using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double fullSpace = double.Parse(Console.ReadLine());
            double volum = (a / 10) * (b / 10) * (c / 10 );
            double freeSpace = volum - (volum * fullSpace / 100);
            Console.WriteLine($"{freeSpace:f3}");
        }
    }
}
