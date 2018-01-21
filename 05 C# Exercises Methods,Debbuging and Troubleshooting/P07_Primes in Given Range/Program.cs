using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Prime_Checker
{
    class Program
    {
        static bool IsPrime(int num)
        {
            bool prime = true;
            if (num < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
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
            int count = 1;
            bool status = false;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i) == true)
                {
                    count += 1;
                    if (count == 2)
                    {
                        Console.Write("{0}", i);
                        
                    }
                    else
                    {
                        Console.Write(", {0}", i);
                    }
                    
                }
               
            }
        }
    }
}

