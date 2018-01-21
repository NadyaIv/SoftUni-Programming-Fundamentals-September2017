using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace P12_Factorial
{
    class Program
    { static BigInteger Factoriel(int num)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(num));
        }
    }
}
