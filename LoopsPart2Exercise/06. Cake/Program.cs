using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int cake = w * l;
            int piecesOfcake = 0;
            while (piecesOfcake < cake)
            {            
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                int pieces = int.Parse(input);
                piecesOfcake += pieces;
            }
            if (piecesOfcake > cake)
            {
                Console.WriteLine($"No more cake left! You need {piecesOfcake - cake} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cake - piecesOfcake} pieces are left.");
            }
            
        }
    }
}
