using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int m= int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            long ndiv = n / 2;
            int count = 0;
            long subtract = n - m;
            count++;
            while (subtract>=m)
            {
                if(subtract==ndiv)
                {
                    if(y!=0)
                    {
                        subtract=subtract / y;
                      
                    }else
                    {
                        subtract -= m;
                        count++;
                    }
                }
                if(subtract>=m)
                {
                    subtract -= m;
                    count++;
                }
            }
            Console.WriteLine(subtract);
            Console.WriteLine(count);
        }
    }
}
