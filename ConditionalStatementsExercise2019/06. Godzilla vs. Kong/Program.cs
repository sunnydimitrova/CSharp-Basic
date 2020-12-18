using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double clothigPraice = double.Parse(Console.ReadLine());
            double moneyAfterdecor = budget * 0.9;
            double moneyForExtras = 1;
            if (numberOfExtras >= 150)
            {
                double discount = (numberOfExtras * clothigPraice) * 0.1;
                moneyForExtras = (numberOfExtras * clothigPraice) - discount;
            }
            else
            {
                moneyForExtras = numberOfExtras * clothigPraice;
            }
            double moneyLeft = moneyAfterdecor - moneyForExtras;
            if (moneyLeft < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more." , Math.Abs(moneyLeft));
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left." , moneyLeft);
            }

        }
    }
}
