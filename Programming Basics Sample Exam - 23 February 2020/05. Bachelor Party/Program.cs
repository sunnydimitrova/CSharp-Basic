using System;

namespace _05._Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumForSinger = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int incom = 0;
            int guestCounter = 0;
            while (input != "The restaurant is full")
            {
                int numberofPeopleInGrup = int.Parse(input);
                guestCounter += numberofPeopleInGrup;
                if (numberofPeopleInGrup >= 5)
                {
                    incom += numberofPeopleInGrup * 70;
                }
                else
                {
                    incom += numberofPeopleInGrup * 100;
                }
                input = Console.ReadLine();
            }
            if (incom >= sumForSinger)
            {
                Console.WriteLine($"You have {guestCounter} guests and {incom - sumForSinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guestCounter} guests and {incom} leva income, but no singer.");
            }
        }
    }
}
