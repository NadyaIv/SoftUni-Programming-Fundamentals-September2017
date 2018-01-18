using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_3.Printing_Triangle
{
    class Program
    {
        static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k+" ");
                }
            }
            for (int i = n-1; i >= 1; i--)
            {
                Console.WriteLine();
                for (int k = 1; k <=i; k++)
                {
                    Console.Write(k+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
    }
}
