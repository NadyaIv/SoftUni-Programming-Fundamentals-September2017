using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_2.Max_Method
{
    class Program
    { static int GetMax (int a,int b)
        {
            if (a>=b)
            {
                return a;
            }
            else  
            {
                return b;
            }    
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int f = GetMax(a,b);
            int j = GetMax(f,d);
            Console.WriteLine(j);
        }
    }
}