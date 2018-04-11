using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int count = 0;
            int maxlent = 0;
            int startposition=0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if(numbers[i+1]>=(numbers[i]+1))
                {
                    count++;
                    if(maxlent<count)
                    {
                        maxlent = count;
                        startposition = i+1-maxlent;
                    }

                }
                else
                {
                    count = 0;
                }
            }
            
            int endposition = startposition + maxlent;
            for (int j = startposition; j <= endposition ; j++)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}
