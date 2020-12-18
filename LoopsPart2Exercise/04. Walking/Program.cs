using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSteps = 10000;
            int sumOfsteps = 0;
            while (sumOfsteps < neededSteps)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    sumOfsteps += stepsHome;
                    break;
                }
                int steps = int.Parse(input);
                sumOfsteps += steps;
            }
            if (sumOfsteps >= neededSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{neededSteps - sumOfsteps} more steps to reach goal.");
            }
        }
    }
}
