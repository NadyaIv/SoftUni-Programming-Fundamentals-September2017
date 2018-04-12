using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double wingDistance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double distance = (wingFlaps * 1.0 / 1000) * wingDistance;
            double time = wingFlaps * 1.0 / 100 +( wingFlaps/ endurance)*5;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
