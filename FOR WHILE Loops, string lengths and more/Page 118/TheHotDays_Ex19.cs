using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_118
{
    internal class TheHotDays_Ex19
    {
        public static void TheHotWatahs()
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("enter tempeture");
                int temp = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    temp1 = temp;
                }
                else
                {
                    temp2 = temp;
                }
                if (temp2 > temp1)
                {
                    Console.WriteLine("day " + i + " was hoter then the day before");
                }
            }
        }
    }
}
