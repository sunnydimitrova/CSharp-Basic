using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if(minutes > 59)
            {
                hours++;
                minutes = minutes - 60;
            }
            if(hours > 23)
            {
                hours = 0;
            }
            if(minutes < 10)
            {
                Console.WriteLine(hours + ":" + 0 + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
            

            
        }
    }
}
