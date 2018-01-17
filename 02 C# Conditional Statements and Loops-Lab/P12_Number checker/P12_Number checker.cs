using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                var n = int.Parse(input);
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
         
        }
    }
}
