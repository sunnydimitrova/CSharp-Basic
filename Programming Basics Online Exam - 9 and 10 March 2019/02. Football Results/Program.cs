using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGame = Console.ReadLine();
            string secondGame = Console.ReadLine();
            string thirthGame = Console.ReadLine();
            int wonGame = 0;
            int wostGame = 0;
            int drawGame = 0;
            if (firstGame[0] > firstGame[2])
            {
                wonGame++;
            }
            else if (firstGame[0] < firstGame[2])
            {
                wostGame++;
            }
            else if (firstGame[0] == firstGame[2])
            {
                drawGame++;
            }
            if (secondGame[0] > secondGame[2])
            {
                wonGame++;
            }
            else if (secondGame[0] < secondGame[2])
            {
                wostGame++;
            }
            else if (secondGame[0] == secondGame[2])
            {
                drawGame++;
            }
            if (thirthGame[0] > thirthGame[2])
            {
                wonGame++;
            }
            else if (thirthGame[0] < thirthGame[2])
            {
                wostGame++;
            }
            else if (thirthGame[0] == thirthGame[2])
            {
                drawGame++;
            }
            Console.WriteLine($"Team won {wonGame} games.");
            Console.WriteLine($"Team lost {wostGame} games.");
            Console.WriteLine($"Drawn games: {drawGame}");
        }
    }
}
