﻿using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = Console.ReadLine().ToLower();
            if(food == "banana" || food == "apple" || food == "kiwi" || food == "cherry" || food == "lemon" || food == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "tomato" || food == "cucumber" || food == "pepper " || food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
