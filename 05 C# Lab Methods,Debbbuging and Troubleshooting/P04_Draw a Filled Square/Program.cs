using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Draw_a_Filled_Square
{
    class Program
    {   static void Dash( int n)

        {
            Console.WriteLine(new string ('-',2*n));
        }
        static void Lines(int n)
        {
            Console.Write("-");
            for (int i = 0; i <n-1; i++)
            {              
               Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Squared( int n)
        {
            Dash(n);
            for (int i = 0; i < n-2; i++)
            {
                Lines(n);
            }
            Dash(n);
        }
        static void Main(string[] args)
        {
            Squared(int.Parse(Console.ReadLine()));
        }
    }
}
