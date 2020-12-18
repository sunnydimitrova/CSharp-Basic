using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            int sum = 0;
            if (destination == "France")
            {
                if (date == "21-23")
                {
                    sum = night * 30;
                }
                else if (date == "24-27")
                {
                    sum = night * 35;
                }
                else if (date == "28-31")
                {
                    sum = night * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (date == "21-23")
                {
                    sum = night * 28;
                }
                else if (date == "24-27")
                {
                    sum = night * 32;
                }
                else if (date == "28-31")
                {
                    sum = night * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (date == "21-23")
                {
                    sum = night * 32;
                }
                else if (date == "24-27")
                {
                    sum = night * 37;
                }
                else if (date == "28-31")
                {
                    sum = night * 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {sum:f2} leva.");
        }
    }
}
