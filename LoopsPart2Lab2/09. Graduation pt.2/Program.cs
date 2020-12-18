using System;

namespace _09._Graduation_pt._2
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
                else
                {
                    int counter2 = 0;
                    while (counter2 < 1)
                    {
                        grade = double.Parse(Console.ReadLine());
                        if (grade < 4.00)
                        {
                            Console.WriteLine($"{name} has been excluded at {counter} grade");
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                        counter2++;
                    }

                    if (grade < 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    counter++;
                }
            }
            if (sumOfGrade / 12 >= 4)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumOfGrade / 12:f2}");
            }
            
        }
    }
}
