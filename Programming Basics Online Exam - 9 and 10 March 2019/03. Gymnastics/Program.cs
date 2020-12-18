using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string discipline = Console.ReadLine();
            double bulgariaPoints = 0;
            double russiaPoints = 0;
            double italyPoints = 0;
            if (countryName == "Russia")
            {
                if (discipline == "ribbon")
                {
                    russiaPoints = 9.100 + 9.400;
                    Console.WriteLine($"The team of {countryName} get {russiaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - russiaPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "hoop")
                {
                    russiaPoints = 9.300 + 9.800;
                    Console.WriteLine($"The team of {countryName} get {russiaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - russiaPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "rope")
                {
                    russiaPoints = 9.600 + 9.000;
                    Console.WriteLine($"The team of {countryName} get {russiaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - russiaPoints) / 20.0 * 100:f2}%");
                }
            }
            else if (countryName == "Bulgaria")
            {
                if (discipline == "ribbon")
                {
                    bulgariaPoints = 9.600 + 9.400;
                    Console.WriteLine($"The team of {countryName} get {bulgariaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - bulgariaPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "hoop")
                {
                    bulgariaPoints = 9.550 + 9.750;
                    Console.WriteLine($"The team of {countryName} get {bulgariaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - bulgariaPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "rope")
                {
                    bulgariaPoints = 9.500 + 9.400;
                    Console.WriteLine($"The team of {countryName} get {bulgariaPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - bulgariaPoints) / 20.0 * 100:f2}%");
                }
            }
            else if (countryName == "Italy")
            {
                if (discipline == "ribbon")
                {
                    italyPoints = 9.200 + 9.500;
                    Console.WriteLine($"The team of {countryName} get {italyPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - italyPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "hoop")
                {
                    italyPoints = 9.450 + 9.350;
                    Console.WriteLine($"The team of {countryName} get {italyPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - italyPoints) / 20.0 * 100:f2}%");
                }
                else if (discipline == "rope")
                {
                    italyPoints = 9.700 + 9.150;
                    Console.WriteLine($"The team of {countryName} get {italyPoints:f3} on {discipline}.");
                    Console.WriteLine($"{(20 - italyPoints) / 20.0 * 100:f2}%");
                }
            }
        }
    }
}
