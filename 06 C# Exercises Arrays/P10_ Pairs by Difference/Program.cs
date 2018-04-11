using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10__Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int difference =int.Parse( Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j <numbers.Length; j++)
                {
                    if(difference==Math.Abs(numbers[i]-numbers[j]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
