﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
