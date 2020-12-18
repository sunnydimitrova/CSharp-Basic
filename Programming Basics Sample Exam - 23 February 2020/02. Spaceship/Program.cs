using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());
            double volumRaket = width * lenght * hight;
            double oneRoomVolum = (averageHeight + 0.40) * 2 * 2;
            double numberOfAustronavt = Math.Floor(volumRaket / oneRoomVolum);
            if (numberOfAustronavt >= 3 && numberOfAustronavt <= 10)
            {
                Console.WriteLine($"The spacecraft holds {numberOfAustronavt} astronauts.");
            }
            else if (numberOfAustronavt < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (numberOfAustronavt > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
