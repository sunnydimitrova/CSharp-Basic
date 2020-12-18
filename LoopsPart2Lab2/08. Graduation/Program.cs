using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            int maxGrade = 12;
            double sumOfGrade = 0;
            while (counter <= maxGrade)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sumOfGrade += grade;
                    counter++;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {sumOfGrade / 12:f2}");
        }
    }
}
