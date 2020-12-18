using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int counterBadGrades = 0;
            double sumOfGrade = 0;
            int counterOfGrades = 0;
            string nameOfExersice = "";
            while (counterBadGrades < badGrades)
            {
                string input = Console.ReadLine();
                if (input == "Enough")
                {
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    counterBadGrades++;
                }
                counterOfGrades++;
                sumOfGrade += grade;
                nameOfExersice = input;

            }
            if (badGrades == counterBadGrades)
            {
                Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfGrade / counterOfGrades:f2}");
                Console.WriteLine($"Number of problems: {counterOfGrades}");
                Console.WriteLine($"Last problem: {nameOfExersice}");
            }
        }
    }
}
