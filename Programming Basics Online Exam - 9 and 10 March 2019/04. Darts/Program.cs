using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playarName = Console.ReadLine();
            int startingPoints = 301;
            int succesShots = 0;
            int notSuccesShots = 0;
            while (startingPoints != 0)
            {
                string comand = Console.ReadLine();
                if (comand == "Retire")
                {
                    break;
                }
                int dots = int.Parse(Console.ReadLine());               
                if (comand == "Single")
                {
                    dots = dots;
                }
                else if (comand == "Double")
                {
                    dots = dots * 2;
                }
                else if (comand == "Triple")
                {
                    dots = dots * 3;
                }
                if (startingPoints < dots)
                {
                    notSuccesShots++;
                    continue;
                }
                else if (startingPoints >= dots)
                {
                    startingPoints -= dots;
                    succesShots++;
                }                
            }
            if (startingPoints == 0)
            {
                Console.WriteLine($"{playarName} won the leg with {succesShots} shots.");
            }
            else
            {
                Console.WriteLine($"{playarName} retired after {notSuccesShots} unsuccessful shots.");
            }
        }
    }
}
