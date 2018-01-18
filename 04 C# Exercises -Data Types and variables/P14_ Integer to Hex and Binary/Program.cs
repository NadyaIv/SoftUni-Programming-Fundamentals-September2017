using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14__Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decnumber = int.Parse(Console.ReadLine());
            string hecnumber = decnumber.ToString("X");
            string binary = Convert.ToString(decnumber, 2);
            Console.WriteLine(hecnumber);
            Console.WriteLine(binary);
        }
    }
}
