﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Count_the_integer
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
