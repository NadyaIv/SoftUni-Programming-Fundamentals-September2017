using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Multiplicationtable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var time = int.Parse(Console.ReadLine());
            var result = 1;
            if (time>10)
            {
                result = number * time;
                Console.WriteLine(number+" X "+time+" = "+result);
            }
            else 
             {
                for (int i = time; i <= 10; i++)
                {
                    result = number * time;
           
                    Console.WriteLine(number + " X " + time + " = " + result);
                    time += 1;
                }
            }   
          
            
        }
    }
}
