using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_English_Name_оf_the_Last_Digit
{
    class Program
        
    {
        static string GetNumber(string digit)
        {
            string num = digit.Remove(0,digit.Length-1);
            switch (num)
            {
                case "1": return "one";
                    break;
                case "2": return "two";
                    break;
                case "3": return "three";
                    break;
                case "4": return "four";
                    break;
                case "5": return "five";
                    break;
                case "6": return "six";
                    break;
                case "7": return "seven";
                    break;
                case "8": return "eight";
                case "9": return "nine";
                    break;
                default: return "zero";
                    break;
            }

        }
        static void Main(string[] args)
        {
            string f=Console.ReadLine();
            string num = GetNumber(f);
            Console.WriteLine(num);
        }
    }
}
