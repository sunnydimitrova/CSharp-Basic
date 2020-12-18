using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCompetition = int.Parse(Console.ReadLine());
            var secondCompetition = int.Parse(Console.ReadLine());
            var thirtCompetition = int.Parse(Console.ReadLine());
            var seconds = firstCompetition + secondCompetition + thirtCompetition;
            var minets = 0;

            if(seconds > 59)
            {
                minets++;
                seconds = seconds - 60;
            }
            if(seconds > 59)
            {
                minets++;
                seconds = seconds - 60;
            }
            if(seconds < 10)
            {
                Console.WriteLine(minets + ":" + 0 + seconds);
            }
            else
            {
                Console.WriteLine(minets + ":" + seconds);
            }
        }
    }
}
