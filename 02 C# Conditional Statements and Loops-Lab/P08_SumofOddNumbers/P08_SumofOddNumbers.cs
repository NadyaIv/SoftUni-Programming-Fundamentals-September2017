using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
           
        {
            var number = int.Parse(Console.ReadLine());
            var odd = 1;
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += odd;
                Console.WriteLine(odd);
                odd += 2;
                
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
