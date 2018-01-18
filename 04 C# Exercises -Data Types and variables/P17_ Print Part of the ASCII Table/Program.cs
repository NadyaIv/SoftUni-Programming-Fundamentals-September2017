using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17__Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char one = (char)num;
            char two = (char)num2;
            for (char i = one; i <= two; i++)
            {
                Console.Write(" {0}", i);
                 
            }
        }
    }
}
