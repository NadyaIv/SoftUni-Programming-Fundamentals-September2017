using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Math.Pow
{
    class Program
    { static double MathPower( double n,int m)
        {
            double num = 1;
            for (int i = 0; i < m; i++)
            {
                 num = num * n;          
            }
            return num;
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(n,m));
        }
    }
}
