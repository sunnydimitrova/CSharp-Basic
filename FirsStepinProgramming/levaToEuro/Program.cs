using System;

namespace levaToEuro
{
    class Program
    {
        static void Main()
        {
            var leva = int.Parse(Console.ReadLine());
            var euro = leva / 1.95583;
            Console.WriteLine(euro);
          
        }
    }
}
