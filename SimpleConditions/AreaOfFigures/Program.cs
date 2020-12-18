using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();
            if(figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if(figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if(figure == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a * Math.PI);
            }
            else if(figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b) / 2);
            }
        }
    }
}
