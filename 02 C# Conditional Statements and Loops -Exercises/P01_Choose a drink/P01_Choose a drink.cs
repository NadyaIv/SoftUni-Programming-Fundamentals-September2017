using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = Console.ReadLine();
            switch (job)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Busineswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
