using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06__Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new string[] { " "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            int count = 0;
            int lent = 0;
            int startposition = 0;
            

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                   if(lent<count)
                    {
                        lent = count;
                        startposition = i-lent;
                    }
                }
                else
                {
                    count = 0;
                }
               
            }

            int endposition = startposition + lent; ;

            for (int i = startposition+1; i <=endposition+1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
