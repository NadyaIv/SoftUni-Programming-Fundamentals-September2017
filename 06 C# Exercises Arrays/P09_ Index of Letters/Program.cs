using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09__Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();
            int num = 0;
            for (int i = 0; i < letter.Length; i++)
            {   num = (int)letter[i] - 97;
                Console.WriteLine("{0} -> {1}",letter[i],num);
            }
        }
    }
}
