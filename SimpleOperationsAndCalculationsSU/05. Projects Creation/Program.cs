using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int sumProject = project * 3;
            Console.WriteLine($"The architect {name} will need {sumProject} hours to complete {project} project/s.");
        }
    }
}
