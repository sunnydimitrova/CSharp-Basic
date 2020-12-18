using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int homeVolum = w * l * h;
            int volumboxes = 0;
            while (volumboxes <= homeVolum)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int boxes = int.Parse(input);
                    volumboxes += boxes;
            }
            if (homeVolum >= volumboxes)
            {
                int freeSpace = homeVolum - volumboxes;
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                int missingSpace = volumboxes - homeVolum;
                Console.WriteLine($"No more free space! You need {missingSpace} Cubic meters more.");
            }
        }
    }
}
