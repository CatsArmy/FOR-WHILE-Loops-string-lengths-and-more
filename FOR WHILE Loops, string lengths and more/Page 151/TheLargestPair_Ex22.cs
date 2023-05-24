using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_151
{
    internal class TheLargestPair_Ex22
    {
        static bool NonZogi(int num1, int num2)
        {
            bool nonZogi = (num1 % 2 == 0 && num2 % 2 == 0
                || num1 % 2 != 0 && num2 % 2 != 0);
            return nonZogi;
        }
        public static void TheLargestPair()
        {
            int num1 = 0;
            int num2 = 0;
            int maxSum = 0;
            int counter = 0;
            while (NonZogi(num1,num2))
            {
                Console.WriteLine("input num1");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("input num2");
                num2 = int.Parse(Console.ReadLine());
                if (maxSum < num1 + num2)
                    maxSum = num1 + num2;
                counter++;
            }
        Console.WriteLine($"the largest pair is {maxSum} and {counter -1} pairs were inputed");
        }
    }
}
