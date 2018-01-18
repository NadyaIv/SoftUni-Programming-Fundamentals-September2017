using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double result = Math.Abs(num1 - num2);
            if( result >=eps)
            {
                Console.WriteLine("False");
                
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
