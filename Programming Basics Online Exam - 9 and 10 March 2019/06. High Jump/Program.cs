using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededJump = int.Parse(Console.ReadLine());
            int startJump = neededJump - 30;
            int jumpCounter = 0;
            int fildCounter = 0;
            int counter = 0;
            int jump = 0;
            while (jump <= neededJump)
            {
                jump = int.Parse(Console.ReadLine());
                jumpCounter++;
                if (jump <= startJump)
                {
                    fildCounter = 0;
                    while (jump <= startJump)
                    {
                        fildCounter++;
                        counter++;
                        jump = int.Parse(Console.ReadLine());                        
                        if (fildCounter == 2)
                        {
                            break;
                        }                        
                    }                    
                }
                if (jump > startJump)
                {
                    startJump += 5;
                }
                else
                {
                    break;
                }
            }
            if (jump > neededJump)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {neededJump}cm after {jumpCounter + counter} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {startJump}cm after {jumpCounter + counter} jumps.");
            }
        }
    }
}
