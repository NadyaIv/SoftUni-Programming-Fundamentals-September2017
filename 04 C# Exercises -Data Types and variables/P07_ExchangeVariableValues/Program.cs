using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3;
            Console.WriteLine("Before:\r\n" + "a = "+num1+"\n"+"b = "+num2 );
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After:\r\n" + "a = " + num1+"\n" + "b = " + num2);
        }
    }
}
