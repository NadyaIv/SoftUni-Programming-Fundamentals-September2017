using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal regionalCoefficent = 0;
            List<decimal> regional = new List<decimal>();
            for (int i = 0; i < number; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long raindropsCount = input[0];
                long squareMetres = input[1];
                if(squareMetres!=0)
                {
                    regionalCoefficent = raindropsCount*1.0M/ squareMetres;
                    regional.Add(regionalCoefficent);
                }     
            }
            decimal sum = regional.Sum();
            if (density!=0)
            {
                decimal result = sum / density;
                Console.WriteLine("{0:f3}", result);

            }else 
            {
                Console.WriteLine("{0:f3}", sum);
            }
            

        }
    }
}
