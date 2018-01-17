using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int multiply = 1;
            for (int i = 1; i <= 10; i++)
            {
                multiply = number * i;
                Console.WriteLine(number+" X "+i+" = "+multiply);
            }
        }
    }
}
