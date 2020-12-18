using System;

namespace LoopsPart2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());
            int currentBook = 0;
            while (currentBook < numberOfBooks)
            {
               string bookName = Console.ReadLine();
                if (bookName == book)
                {
                    break;
                }
                currentBook++;
            }
            if (numberOfBooks == currentBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {currentBook} books.");
            }
            else
            {
                Console.WriteLine($"You checked {currentBook} books and found it.");
            }
        }
    }
}
