using System;

namespace SimpleOperationsAndCalculationsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var fullSpace = double.Parse(Console.ReadLine());
            var volumDM = (a * b * c) / 1000;
            var liters = volumDM - (volumDM * (fullSpace / 100));
            Console.WriteLine("{0:f3}" , liters);
        }
    }
}
