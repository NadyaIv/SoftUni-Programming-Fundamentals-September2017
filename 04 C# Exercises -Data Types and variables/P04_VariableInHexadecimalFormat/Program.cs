using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
           string num = Console.ReadLine();
            int value = Convert.ToInt32(num, 16);
            Console.WriteLine(value);
        }
    }
}
