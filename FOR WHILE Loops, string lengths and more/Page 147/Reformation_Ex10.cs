using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_WHILE_Loops__string_lengths_and_more.Page_147
{
    internal class Reformation_Ex10
    {
        public static void Reformation()
        {
            double agree = 0;
            int disagree = 0;
            int noOpionions = 0;
            Console.WriteLine("enter number of people");
            double numOfVotes = double.Parse(Console.ReadLine());
            Console.WriteLine("type y if you agree");
            Console.WriteLine("type n if you disagree");
            Console.WriteLine("type d if you dont wnat to answer");
            for (int i = 0; i < numOfVotes; i++)
            {
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                    agree++;
                else if (answer == 'n')
                    disagree++;
                else if (answer == 'd')
                    noOpionions++;
            }
            Console.WriteLine($"Number of people agreed {agree}");
            Console.WriteLine($"Number of people disareed {disagree}");
            Console.WriteLine($"Number of people that didnt answer {noOpionions}");
            double percent = agree / numOfVotes;
            percent *= 100;
            if (percent >= 60)
                Console.WriteLine($"{percent} % voted agree the new rules will apply");
            else
                Console.WriteLine($"{percent} % voted agree the new rules wouldnt apply");
        }
    }
}
