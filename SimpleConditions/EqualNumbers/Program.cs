using System;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstnumb = double.Parse(Console.ReadLine());
            var secondtnumb = double.Parse(Console.ReadLine());
            var thirtnumb = double.Parse(Console.ReadLine());
            var result = firstnumb + secondtnumb + thirtnumb;
            if(result / 3 == firstnumb)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
