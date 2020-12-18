using System;

namespace LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latin alphabet:");
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(" " + letter);
            }
            Console.WriteLine();
        }
    }
}
