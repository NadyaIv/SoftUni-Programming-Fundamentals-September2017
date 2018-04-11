using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] days =
              {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(days[0]);
            }
            else if (n==2)

            {
                Console.WriteLine(days[1]);
            }
            else if (n == 3)

            {
                Console.WriteLine(days[2]);
            }
            else if (n == 4)

            {
                Console.WriteLine(days[3]);
            }
            else if (n == 5)

            {
                Console.WriteLine(days[4]);
            }
            else if (n == 6)

            {
                Console.WriteLine(days[5]);
            }
            else if (n == 7)

            {
                Console.WriteLine(days[6]);
            }
            else 

            {
                Console.WriteLine("Invalid Day!");
            }
        }


    }
}
