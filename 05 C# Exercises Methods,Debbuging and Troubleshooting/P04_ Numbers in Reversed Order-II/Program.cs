using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04__Numbers_in_Reversed_Order_II
{
    class Program
    {
        static string ReversOreder(string digit)
        { string revdigit = "";
            for (int i =digit.Length-1; i >=0 ; i--)
            {
                 revdigit += digit[i];
               
            }
            return revdigit;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversOreder(number));
        }
    }
}
