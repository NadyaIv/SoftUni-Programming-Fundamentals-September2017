﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_HelloName
{
    class Program
    { static void GetName( string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main(string[] args)
        {
            GetName(Console.ReadLine());

        }
    }
}
