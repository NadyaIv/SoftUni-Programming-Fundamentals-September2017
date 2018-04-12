using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalprice = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { decimal pricepercapsula= decimal.Parse(Console.ReadLine());
                string dateinput = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateinput, "d/M/yyyy", null);
                long capsulecount = long.Parse(Console.ReadLine());
                int dateMonth = DateTime.DaysInMonth(date.Year,date.Month);
                decimal price = (capsulecount * dateMonth) * pricepercapsula;
                Console.WriteLine("The price for the coffee is: ${0:f2}",price);
                totalprice += price;

            }
            Console.WriteLine("Total: ${0:f2}",totalprice);
        }
    }
}
