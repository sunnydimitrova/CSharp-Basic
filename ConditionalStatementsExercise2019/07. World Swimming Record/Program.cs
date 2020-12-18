using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            double timeWithoutResistence = distance * timeForMeter;
            double resistance = Math.Floor(distance / 15) * 12.5;
            double ivanStime = timeWithoutResistence + resistance;
            double difference = worldRecord - ivanStime;
            if (ivanStime < worldRecord)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds." , ivanStime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower." , Math.Abs(difference));
            }
        }
    }
}
