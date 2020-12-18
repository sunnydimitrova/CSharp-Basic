using System;

namespace _05._TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int timeAfterFifty = minutes + 15;
            if (timeAfterFifty > 59)
            {
                hour++;
                minutes = (minutes - 60) + 15;
            }
            else
            {
                minutes = minutes + 15;
            }
            if (hour > 23)
            {
                hour = 0;               
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
