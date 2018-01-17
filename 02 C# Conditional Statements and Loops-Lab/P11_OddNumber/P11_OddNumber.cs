using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_ODDNUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                bool n = true;

                while (n == true)
                {
                    Console.WriteLine("Please write an odd number.");
                    var number2 = int.Parse(Console.ReadLine());
                    if (number2 % 2 == 0)
                    {
                        n = true;
                    }
                    else
                    {
                        n = false;
                        Console.WriteLine("The number is: " + Math.Abs(number2));
                    }
                }      
            }
                
            else
            {
                Console.WriteLine("The number is: " + Math.Abs(number));
            }
        }
    }
}
