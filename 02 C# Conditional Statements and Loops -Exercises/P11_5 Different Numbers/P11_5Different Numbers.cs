using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int difference = secondDigit - firstDigit;
            if(difference<5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = firstDigit; i < secondDigit; i++)
                {
                    for (int j = firstDigit; j < secondDigit; j++)
                    {
                        for (int k = firstDigit; k < secondDigit; k++)
                        {
                            for (int l = firstDigit; l < secondDigit; l++)
                            {
                                for (int m = firstDigit; m <=secondDigit; m++)
                                {
                                    if(firstDigit<=i && i<j&& j<k && k<l && l<m && m<=secondDigit)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
