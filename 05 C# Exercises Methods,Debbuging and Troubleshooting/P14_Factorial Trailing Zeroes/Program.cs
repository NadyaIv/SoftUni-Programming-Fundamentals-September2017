using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace P14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static BigInteger Factoriel(BigInteger num)
        {
            BigInteger factoriel = 1;
            for (BigInteger i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static long TrailingZero(BigInteger num)
        {
            
           BigInteger  left =num;
            int count = 0;
            while (left > 0)
            {
                BigInteger r = left % 10;
                if (r == 0)
                {
                    count += 1;
                    
                }
                else
                {
                    break;
                }
                left = left / 10;  
            }
            
            return count;
        }
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger nim=Factoriel(num);
            Console.WriteLine(TrailingZero(nim));
        }
    }
}
