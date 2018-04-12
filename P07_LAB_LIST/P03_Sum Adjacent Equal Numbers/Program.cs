using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            decimal sum = 0;
            for (int i = 0; i < numbers.Count-1; i++)
            {   
                if(numbers[i]==numbers[i+1])
                {
                    sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers[i] = sum;
                    i =-1;
                }
               
            }
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }
        }
    }
}
