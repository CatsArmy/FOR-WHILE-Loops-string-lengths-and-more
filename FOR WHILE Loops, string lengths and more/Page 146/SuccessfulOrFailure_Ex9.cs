using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_146
{
    internal class SuccessfulOrFailure_Ex9
    {
        public static void SuccessfulOrFailure()
        {
            int maxGrade = 0;
            int minGrade = 100;
            int grade = 0;
            while (grade > -1)
            {
                Console.WriteLine("Enter a grade");
                grade = int.Parse(Console.ReadLine());
                if (grade > maxGrade)
                {
                    maxGrade = grade;
                }
                if (grade < minGrade && grade >= 0)
                {
                    minGrade = grade;
                }
                if (grade >= 95)
                {
                    Console.WriteLine("Succesfuly passed");
                }
                if (grade <= 55 && grade >= 0)
                {
                    Console.WriteLine("Failure");
                }
            }
            Console.WriteLine($"The highest score is {maxGrade}");
            Console.WriteLine($"the lowerst score is {minGrade}");
        }
    }
}
