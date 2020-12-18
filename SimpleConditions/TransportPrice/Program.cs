﻿using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double price = 0;
            double taxiRate = 0;
            if(dayNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if(distance < 20)
            {
                price = 0.70 + distance * taxiRate;
            }
            else if(distance < 100)
            {
                price = distance * 0.09;      
            }
            else
            {
                price = distance * 0.06;
            }
            Console.WriteLine(price);

        }
    }
}
