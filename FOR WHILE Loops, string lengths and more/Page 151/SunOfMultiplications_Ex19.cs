using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_151
{
    internal class SunOfMultiplications_Ex19
    {
        public static void SunOfMultiplications()
        {
            int sum = 0;
            int mult = 1;
            while (mult == 0)
            {
                Console.Write("Enter num 1:");
                int numPairs = int.Parse(Console.ReadLine());
                Console.Write("Enter num 2:");
                int num = int.Parse(Console.ReadLine());
                mult = numPairs * num;
                Console.WriteLine($"The numbers muplication is {mult}");
                Console.WriteLine($"mult: {mult}");
                sum += mult;
            }
            Console.WriteLine($"sum: {sum}");
            if (sum > 0)
                Console.WriteLine("The sum is positive.");
            else if (sum < 0)
                Console.WriteLine("The sum is negative.");
            else
                Console.WriteLine("The sum is zero.");
        }
    }
}
