using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var number1 = int.Parse(Console.ReadLine());
            if (number < number1)
            {
                for (int i = number; i <= number1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = number1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
