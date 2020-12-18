using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                if (letter == 'a')
                {
                    sum += 1;
                }
                else if (letter == 'e')
                {
                    sum += 2;
                }
                else if (letter == 'i')
                {
                    sum += 3;
                }
                else if (letter == 'o')
                {
                    sum += 4;
                }
                else if (letter == 'u')
                {
                    sum += 5;
                }
                Console.WriteLine("Vowels sum = " + sum);
            }
        }
    }
}
