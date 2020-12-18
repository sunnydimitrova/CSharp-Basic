using System;

namespace workWithPlaceholder
{
    class workWithPlaceholder

    {
        static void Main()
        {
            Console.Write("First name = ");
            var firstName = Console.ReadLine();
            Console.Write("Second name = ");
            var secondName = Console.ReadLine();
            Console.Write("Age = ");
            var age = Console.ReadLine();
            Console.Write("Town = ");
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, secondName, age, town);

        }
    }
}
