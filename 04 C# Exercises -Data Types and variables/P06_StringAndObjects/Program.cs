using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = word1 +" "+ word2;
           
            string word4 = Console.ReadLine();
            word4 = word3;
            Console.WriteLine(word4);

        }
    }
}
