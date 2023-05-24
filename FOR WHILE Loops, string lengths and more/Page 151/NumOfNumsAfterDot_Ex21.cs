using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_151
{
    internal class NumOfNumsAfterDot_Ex21
    {
        public static void AfterDot()
        {
            Console.WriteLine("input an double number like 0.123456");
            double dotNum = double.Parse(Console.ReadLine());
            string afterDot = dotNum.ToString().Split('.')[1];
            Console.WriteLine(@$"Value of after the dot {afterDot}
and has the length of {afterDot.Length}");
            

        }
    }
}
