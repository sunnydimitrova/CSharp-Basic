using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinSake = 0;
            int proteinBar = 0;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == "Back")
                {
                    back++;
                }
                else if (input == "Chest")
                {
                    chest++;
                }
                else if (input == "Legs")
                {
                    legs++;
                }
                else if (input == "Abs")
                {
                    abs++;
                }
                else if (input == "Protein shake")
                {
                    proteinSake++;
                }
                else if (input == "Protein bar")
                {
                    proteinBar++;
                }
            }
            int peopleTraining = back + abs + legs + chest;
            double prosentOfTriningPeople = (peopleTraining / (1.0 * n) ) * 100;
            int buyProtein = proteinBar + proteinSake;
            double prosentCell = (buyProtein / (1.0 * n)) * 100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinSake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{prosentOfTriningPeople:f2}% - work out");
            Console.WriteLine($"{prosentCell:f2}% - protein");
        }
    }
}
