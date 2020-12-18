using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfSushi = Console.ReadLine();
            string nameRestorant = Console.ReadLine();
            int numberOfPorsion = int.Parse(Console.ReadLine());
            string deliver = Console.ReadLine();
            double priceForSushi = 0;
            if (nameRestorant == "Sushi Zone")
            {
                if (typeOfSushi == "sashimi")
                {
                    priceForSushi = numberOfPorsion * 4.99;
                }
                else if (typeOfSushi == "maki")
                {
                    priceForSushi = numberOfPorsion * 5.29;
                }
                else if (typeOfSushi == "uramaki")
                {
                    priceForSushi = numberOfPorsion * 5.99;
                }
                else if (typeOfSushi == "temaki")
                {
                    priceForSushi = numberOfPorsion * 4.29;
                }
            }
            else if (nameRestorant == "Sushi Time")
            {
                if (typeOfSushi == "sashimi")
                {
                    priceForSushi = numberOfPorsion * 5.49;
                }
                else if (typeOfSushi == "maki")
                {
                    priceForSushi = numberOfPorsion * 4.69;
                }
                else if (typeOfSushi == "uramaki")
                {
                    priceForSushi = numberOfPorsion * 4.49;
                }
                else if (typeOfSushi == "temaki")
                {
                    priceForSushi = numberOfPorsion * 5.19;
                }
            }
            else if (nameRestorant == "Sushi Bar")
            {
                if (typeOfSushi == "sashimi")
                {
                    priceForSushi = numberOfPorsion * 5.25;
                }
                else if (typeOfSushi == "maki")
                {
                    priceForSushi = numberOfPorsion * 5.55;
                }
                else if (typeOfSushi == "uramaki")
                {
                    priceForSushi = numberOfPorsion * 6.25;
                }
                else if (typeOfSushi == "temaki")
                {
                    priceForSushi = numberOfPorsion * 4.75;
                }
            }
            else if (nameRestorant == "Asian Pub")
            {
                if (typeOfSushi == "sashimi")
                {
                    priceForSushi = numberOfPorsion * 4.50;
                }
                else if (typeOfSushi == "maki")
                {
                    priceForSushi = numberOfPorsion * 4.80;
                }
                else if (typeOfSushi == "uramaki")
                {
                    priceForSushi = numberOfPorsion * 5.50;
                }
                else if (typeOfSushi == "temaki")
                {
                    priceForSushi = numberOfPorsion * 5.50;
                }
            }
            else
            {
                Console.WriteLine($"{nameRestorant} is invalid restaurant!");
                return;
            }
            if (deliver == "Y")
            {
                double sum = priceForSushi * 1.20;
                Console.WriteLine($"Total price: {Math.Ceiling(sum)} lv.");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(priceForSushi)} lv.");
            }
        }
    }
}
