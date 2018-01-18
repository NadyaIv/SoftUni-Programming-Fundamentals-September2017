using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace P18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
           BigInteger num =BigInteger.Parse(Console.ReadLine());
            if (num <= 0 && num >= -128)
            {
                Console.WriteLine(num + " can fit in:");

                Console.WriteLine(" * sbyte");
                Console.WriteLine(" * short");
                Console.WriteLine(" * int");
                Console.WriteLine(" * long");
            }
            else if ( num<-128 && num>=-32768)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * short");
                Console.WriteLine(" * int");
                Console.WriteLine(" * long");
            }
            else if(num<-32768 && num>= -2147483648 )
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * int");
                Console.WriteLine(" * long");
            }
            else if (num< -2147483648 && num>=-9223372036854775808)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * long");

            }
            else if ( num>=0 && num<=127)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * sbyte");
                Console.WriteLine(" * byte");
                Console.WriteLine(" * short");
                Console.WriteLine(" * ushort");
                Console.WriteLine(" * int");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");
            } 
            else if ( num>127 && num <=255)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * byte");
                Console.WriteLine(" * short");
                Console.WriteLine(" * ushort");
                Console.WriteLine(" * int");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");

            }
            else if ( num >255 && num <= 32767)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * short");
                Console.WriteLine(" * ushort");
                Console.WriteLine(" * int");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");

            }
            else if ( num >32767 && num<= 65535)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * ushort");
                Console.WriteLine(" * int");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");

            } else if ( num >65535 && num <= 2147483647)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * int");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");
            }
            else if ( num> 2147483647 && num<= 4294967295)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * uint");
                Console.WriteLine(" * long");
            }
            else if ( num > 4294967295 && num<= 9223372036854775807)
            {
                Console.WriteLine(num + " can fit in:");
                Console.WriteLine(" * long");
            }
               else
            {
                Console.WriteLine(num+" can't fit in any type");
            }
                    
                   
         }

    }
}
