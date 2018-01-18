using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            bool yes = Convert.ToBoolean(value);
            if ( yes == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
