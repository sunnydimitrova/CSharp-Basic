using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string projectName = Console.ReadLine();
            double sumOFGrade = 0;
            double finalGrade = 0;
            int gradeCounter = 0;
            double finalGradeForOneProject = 0;
            while (projectName != "Finish")
            {
                sumOFGrade = 0;
                for (int i = 0; i < n; i++)
                {                    
                    double grade = double.Parse(Console.ReadLine());
                    sumOFGrade += grade;
                }
                finalGradeForOneProject = sumOFGrade / n;
                finalGrade += finalGradeForOneProject;
                gradeCounter++;
                Console.WriteLine($"{projectName} - {finalGradeForOneProject:f2}.");
                projectName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {finalGrade / gradeCounter:f2}.");
            
        }
    }
}
