using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;
            int max = 0;
            int startposition = -1;

            for (int i = 0; i < input.Count - 1; i++)
            {

                if (input[i] == input[i + 1])
                {
                    count++;
                    if (max < count)
                    {
                        max = count;
                        startposition = i - max;
                    }
                }
                else
                {
                    count = 0;
                

                }
                
            }
                int endposition = startposition + max ;
                for (int j = startposition+1; j <= endposition+1; j++)
                {
                    Console.Write(input[j] + " ");
                }
            
        }
    }
}
