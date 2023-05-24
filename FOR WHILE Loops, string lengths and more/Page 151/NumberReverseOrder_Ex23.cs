using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_151
{
    internal class NumberReverseOrder_Ex23
    {
        public static void ReverseNum()
        {
            Console.WriteLine("input a num that will be reversed");
            int num = int.Parse(Console.ReadLine());
            string revsNum = num.ToString();
            char[] munRevs = revsNum.ToCharArray();
            revsNum = "";
            for (int i = munRevs.Length - 1; i >= 0; i--)
                revsNum += munRevs[i];
            num = int.Parse(revsNum);
            Console.WriteLine($"reverse num: {num}");
        }
    }
}
