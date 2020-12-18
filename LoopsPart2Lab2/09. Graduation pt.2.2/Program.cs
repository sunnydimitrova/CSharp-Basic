using System;

namespace _09._Graduation_pt._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            int maxGrade = 12;
            double sumOfGrade = 0;
            int expel = 0;
            while (counter <= maxGrade)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    counter++;
                    sumOfGrade += grade;
                }
                else
                {
                    expel++;
                    if (expel > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    }
                }                  
            }
            if (sumOfGrade / 12 >= 4)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumOfGrade / 12:f2}");
            }
        }
    }
}
