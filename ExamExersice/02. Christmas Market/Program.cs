using System;

namespace _02._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyDemanded = double.Parse(Console.ReadLine());
            double numberOfFantasy = double.Parse(Console.ReadLine());
            double numberOfHorrour = double.Parse(Console.ReadLine());
            double numberOfDrama = double.Parse(Console.ReadLine());
            double sum = (numberOfFantasy * 14.90) + (numberOfHorrour * 9.80) + (numberOfDrama * 4.30);
           
            double sumAfterDDS = sum - (sum * 20 / 100);
            if (sumAfterDDS - moneyDemanded < 0)
            {
                Console.WriteLine("{0:f2} money needed.", Math.Abs(sumAfterDDS - moneyDemanded));
            }
            else
            {
                double sumExceedingTheTarget = sumAfterDDS - moneyDemanded;
                double sumForSellers = Math.Floor(sumExceedingTheTarget * 10 / 100);
                double sumForDonation = moneyDemanded + (sumExceedingTheTarget - sumForSellers);

                Console.WriteLine($"{sumForDonation:f2} leva donated.");
                Console.WriteLine("Sellers will receive {0} leva.", sumForSellers);
            }

        }
    }
}
