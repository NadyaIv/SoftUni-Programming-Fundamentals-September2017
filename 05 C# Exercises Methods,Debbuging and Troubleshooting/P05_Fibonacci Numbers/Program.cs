using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Fibonacci_Numbers
{
    class Program
    {
        static long FibbonachiNumbers(long num)
        {
            int num1 = 1;
            int num2 = 1;
            for (int i = 0; i <num; i++)
            {
                int num3 = num1;
                num1 = num2 ;
                num2 = num2 + num3;
            }
            return num1;
        }
        static void Main(string[] args)
        {
            long numer = long.Parse(Console.ReadLine());
            Console.WriteLine(FibbonachiNumbers(numer));
        }
    }
}
