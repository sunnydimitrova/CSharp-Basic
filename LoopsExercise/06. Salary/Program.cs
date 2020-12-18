using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int salaryAfterfine = salary;
            for (int i = 0; i < n; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salaryAfterfine -= 150;
                }
                else if (website == "Instagram")
                {
                    salaryAfterfine -= 100;
                }
                else if (website == "Reddit")
                {
                    salaryAfterfine -= 50;
                }
                if (salaryAfterfine <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salaryAfterfine > 0)
            {
                Console.WriteLine($"{salaryAfterfine}");
            }
            
        }
    }
}
