using System;

namespace LoopsPart2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " ";

            while (text != "Stop")
            {
                text = Console.ReadLine();
                if (text == "Stop")
                {
                    break;
                }
            }
        }
    }
}
