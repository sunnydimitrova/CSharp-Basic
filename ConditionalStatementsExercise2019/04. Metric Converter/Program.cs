using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            if (inputUnit == "mm" && outputUnit == "cm")
            {
                double sum = number / 10;
                Console.WriteLine($"{sum:f3}");
            }
            else if (inputUnit == "mm" && outputUnit == "m")
            {
                double sum = number / 1000;
                Console.WriteLine($"{sum:f3}");
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                double sum = number * 10;
                Console.WriteLine($"{sum:f3}");
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                double sum = number / 100;
                Console.WriteLine($"{sum:f3}");
            }
            else if (inputUnit == "m" && outputUnit == "mm")
            {
                double sum = number * 1000;
                Console.WriteLine($"{sum:f3}");
            }
            else if (inputUnit == "m" && outputUnit == "cm")
            {
                double sum = number * 100;
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
