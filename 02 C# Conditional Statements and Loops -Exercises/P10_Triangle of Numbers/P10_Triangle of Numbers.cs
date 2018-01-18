using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int number = 1;
            while(digit!=number-1)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(number+" ");
                }
                Console.WriteLine();
                number++;
            }
        }
    }
}
