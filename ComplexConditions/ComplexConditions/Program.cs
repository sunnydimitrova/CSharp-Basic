using System;

namespace ComplexConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gander = Console.ReadLine().ToLower();

            if(age >= 16)
            {
                if (gander == "m") { Console.WriteLine("Mr."); }
                else if (gander == "f") { Console.WriteLine("Ms."); }
            }
            else if(age < 16)
            {
                if (gander == "m") { Console.WriteLine("Master"); }
                else if (gander == "f") { Console.WriteLine("Miss"); }
            }
        }
    }
}
