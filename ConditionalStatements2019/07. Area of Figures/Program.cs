using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}" , a * a);
            }
            else if (figure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}" , side * side2);
            }
            else if (figure == "circle")
            {
                double radios = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}" , radios * radios * Math.PI);
            }
            else
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideh = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}" , (sideA * sideh) / 2);
            }
        }
    }
}
