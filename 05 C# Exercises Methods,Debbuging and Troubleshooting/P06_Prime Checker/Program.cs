using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Prime_Checker
{
    class Program
    {  static bool IsPrime(long num)
        {
            bool prime = true;
            if (num < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <=Math.Sqrt(num); i++)
                {

                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            return prime;
        }

        static void Main(string[] args)
        {
            long num= long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }
    }
}
