using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double price = 1;
            switch (job)
            {
                case "Athlete":
                    price = quantity * 0.70;
                    Console.WriteLine($"The {job} has to pay {price:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantity;
                    Console.WriteLine($"The {job} has to pay {price:F2}.");
                    break;
                case "SoftUni Student":
                    price = quantity * 1.70;
                    Console.WriteLine($"The {job} has to pay {price:F2}.");
                    break;
                default:
                    price = 1.20 * quantity; 
                    Console.WriteLine($"The {job} has to pay {price:F2}.");
                    break;
            }
        }
    }
}
