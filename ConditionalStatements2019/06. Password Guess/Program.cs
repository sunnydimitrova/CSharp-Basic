using System;

namespace _06._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passlord = Console.ReadLine();
            string text = 
                "s3cr3t!P@ssw0rd";
            if (passlord == text)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
