using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06__Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] reversed = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[input.Length - 1 - i] = input[i];
            }
            foreach (var item in reversed)
            {
                Console.Write(item+" ");
            }
        }
    }
}
