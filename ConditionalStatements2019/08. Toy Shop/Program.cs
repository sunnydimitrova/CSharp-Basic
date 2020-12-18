using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            double totalMoney = (puzzels * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (truck * 2);
            double moneyAfterRent = totalMoney - (totalMoney * 10 / 100);
            int numberOfToys = puzzels + dolls + bears + minions + truck;
            if (numberOfToys >= 50)
            {
                double moneyAfterDiscount = totalMoney - (totalMoney * 25 / 100);                
                double moneyafterRent = moneyAfterDiscount - (moneyAfterDiscount * 10 / 100);
                double moneyLeftOver = moneyafterRent - tripPrice;
                Console.WriteLine("Yes! {0:f2} lv left." , moneyLeftOver);
            }
            else if (numberOfToys < 50 && moneyAfterRent - tripPrice > 0)
            {               
                    Console.WriteLine("Yes! {0:f2} lv left.", moneyAfterRent - tripPrice);                
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed." , Math.Abs(moneyAfterRent - tripPrice));
            }
            
        }
    }
}
