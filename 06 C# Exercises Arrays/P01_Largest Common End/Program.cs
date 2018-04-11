using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string words1 = Console.ReadLine();
            string words2 = Console.ReadLine();
            string[] first = words1.Split(' ');
            string[] second = words2.Split(' ');
            int length = Math.Min(first.Length, second.Length);
            int leftcount = 0;
            int rightcount = 0;
            for (int i = 0; i < length; i++)
            {
                if (first[i]==second[i])
                {
                    leftcount += 1;
                }
                if (first[first.Length-1-i]== second[second.Length - 1 - i])
                {
                    rightcount+=1;
                }
            }
            Console.WriteLine(Math.Max(leftcount,rightcount));
        }
    }
}
