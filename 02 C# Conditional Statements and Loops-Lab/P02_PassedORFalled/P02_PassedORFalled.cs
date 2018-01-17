using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_PassedORFalled
{
    class Program
    {
        static void Main(string[] args)
        {
            var grdae = double.Parse(Console.ReadLine());
            if (grdae >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
