using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordfirst = Console.ReadLine().ToLower();
            var wordsecon = Console.ReadLine().ToLower();
            if(wordfirst == wordsecon)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
