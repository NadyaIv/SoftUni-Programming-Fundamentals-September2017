using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_VowelOrDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (int.TryParse(name, out int x))
            {
                Console.WriteLine("digit");
            }
            else
            {

                switch (name)
                {
                    case "a":
                        Console.WriteLine("vowel");
                        break;
                    case "o":
                        Console.WriteLine("vowel");
                        break;
                    case "e":
                        Console.WriteLine("vowel");
                        break;
                    case "i":
                        Console.WriteLine("vowel");
                        break;
                    case "u":
                        Console.WriteLine("vowel");
                        break;
                    case "y":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;

                }
            }
            
        }
        
    }
}
