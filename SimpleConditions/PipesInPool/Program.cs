using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());
            double water = (p1 + p2) * hour;
            if(water <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", water, p1, p2);
                    
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour, v);
            } //TODO

        }
    }
}
