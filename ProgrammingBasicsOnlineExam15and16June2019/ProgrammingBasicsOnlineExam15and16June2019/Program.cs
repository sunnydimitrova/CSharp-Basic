using System;

namespace ProgrammingBasicsOnlineExam15and16June2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentnumberOfFilm = 0;
            string currentFilm = "";
            int sumOfLetters = 0;
            int theBestFilm = int.MinValue;
            for (int i = 0; i < 7; i++)
            {
                string favoriteMovie = Console.ReadLine();
                if (favoriteMovie == "STOP")
                {
                    break;
                }
                currentnumberOfFilm++;
                sumOfLetters = 0;
                for (int currentLetter = 0; currentLetter <= favoriteMovie.Length - 1; currentLetter++)
                {
                    int letter = favoriteMovie[currentLetter];
                    if (letter >= 65 && letter <= 90)
                    {
                        sumOfLetters += letter - favoriteMovie.Length;
                    }
                    else if (letter >= 97 && letter <= 122)
                    {
                        sumOfLetters += letter - (2 * favoriteMovie.Length);
                    }
                    else
                    {
                        sumOfLetters += letter;
                    }
                }
                if (sumOfLetters > theBestFilm)
                {
                    theBestFilm = sumOfLetters;
                    currentFilm = favoriteMovie;
                }
            }
            if (currentnumberOfFilm >= 7)
            {
                Console.WriteLine("The limit is reached.");
                Console.WriteLine($"The best movie for you is {currentFilm} with {theBestFilm} ASCII sum.");
            }
            else
            {
                Console.WriteLine($"The best movie for you is {currentFilm} with {theBestFilm} ASCII sum.");
            }
        }
    }
}
