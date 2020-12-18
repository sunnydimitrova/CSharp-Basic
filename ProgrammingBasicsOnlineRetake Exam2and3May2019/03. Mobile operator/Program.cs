using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termOfTheContract = Console.ReadLine();
            string typeOfCountract = Console.ReadLine();
            string internet = Console.ReadLine();
            int numberOfMountForPay = int.Parse(Console.ReadLine());
            double sum = 0;
            if (termOfTheContract == "one")
            {
                if (typeOfCountract == "Small")
                {
                    if (internet == "yes")
                    {
                        sum = (9.98 + 5.50) * numberOfMountForPay;
                    }
                    else
                    {
                        sum = 9.98 * numberOfMountForPay;
                    }
                }
                else if (typeOfCountract == "Middle")
                {
                    if (internet == "yes")
                    {
                        sum = (18.99 + 4.35) * numberOfMountForPay;
                    }
                    else
                    {
                        sum = 18.99 * numberOfMountForPay;
                    }
                }
                else if (typeOfCountract == "Large")
                {
                    if (internet == "yes")
                    {
                        sum = (25.98 + 4.35) * numberOfMountForPay;
                    }
                    else
                    {
                        sum = 25.98 * numberOfMountForPay;
                    }
                }
                else if (typeOfCountract == "ExtraLarge")
                {
                    if (internet == "yes")
                    {
                        sum = (35.99 + 3.85) * numberOfMountForPay;
                    }
                    else
                    {
                        sum = 35.99 * numberOfMountForPay;
                    }
                }
            }
            else if (termOfTheContract == "two")
            {
                if (typeOfCountract == "Small")
                {
                    if (internet == "yes")
                    {
                        sum = ((8.58 + 5.50) * numberOfMountForPay) * 0.9625;
                    }
                    else
                    {
                        sum = (8.58 * numberOfMountForPay) * 0.9625;
                    }
                }
                else if (typeOfCountract == "Middle")
                {
                    if (internet == "yes")
                    {
                        sum = ((17.09 + 4.35) * numberOfMountForPay) * 0.9625;
                    }
                    else
                    {
                        sum = (17.09 * numberOfMountForPay) *0.9625;
                    }
                }
                else if (typeOfCountract == "Large")
                {
                    if (internet == "yes")
                    {
                        sum = ((23.59 + 4.35) * numberOfMountForPay) * 0.9625;
                    }
                    else
                    {
                        sum = (23.59 * numberOfMountForPay) * 0.9625;
                    }
                }
                else if (typeOfCountract == "ExtraLarge")
                {
                    if (internet == "yes")
                    {
                        sum = ((31.79 + 3.85) * numberOfMountForPay) * 0.9625;
                    }
                    else
                    {
                        sum = (31.79 * numberOfMountForPay) * 0.9625;
                    }
                }
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
