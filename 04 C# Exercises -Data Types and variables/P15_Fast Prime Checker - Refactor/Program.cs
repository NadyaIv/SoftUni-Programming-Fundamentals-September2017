using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
          
            for (int i = 2; i <= number; i++)
            {
                int count = 0;
                double sqnumber =Math.Sqrt(i);
                for (int k=1 ; k <= sqnumber; k++)
                {
                    if (i % k == 0)
                    {
                        count++;                   
                    }    

                }
                if (count == 1)
                {
                    Console.WriteLine(i + " -> True");
                }
                else
                {
                    Console.WriteLine(i + " -> False");
                }

            }
           
        }
    }
}
