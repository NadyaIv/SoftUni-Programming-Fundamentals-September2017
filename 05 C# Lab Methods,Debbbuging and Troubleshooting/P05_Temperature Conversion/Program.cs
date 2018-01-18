using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Temperature_Conversion
{
    class Program
    {static double ConvertFarenhToCels( double farenh)
        {
            double cels = (farenh - 32) * 5 / 9;
            return cels;
        }
        static void Main(string[] args)
        { double farenh = double.Parse(Console.ReadLine());
            double cels =ConvertFarenhToCels(farenh);
            Console.WriteLine("{0:f2}",cels);
        }
    }
}
