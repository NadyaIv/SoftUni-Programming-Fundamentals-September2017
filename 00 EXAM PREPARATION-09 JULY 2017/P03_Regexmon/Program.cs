using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternDido = @"[^a-zA-Z\-]+";
            string patternBojo = @"[a-zA-Z]+-[a-zA-Z]+";
            Regex Dido = new Regex(patternDido);
            Regex Bojo = new Regex(patternBojo);
          

             while(true)
            {
                Match matchDido = Dido.Match(input);
                if (!matchDido.Success)
                {
                    break;

                }
                Console.WriteLine(matchDido.Value);
                int firstsymbolDido = matchDido.Index;
                input = input.Substring(firstsymbolDido + matchDido.Length);

                Match matchBojo = Bojo.Match(input);
                if (!matchDido.Success)
                {
                    break;

                }
                Console.WriteLine(matchBojo.Value);
                int firstsymbolBojo = matchBojo.Index;
                input = input.Substring(firstsymbolBojo + matchBojo.Length);
            }
           
            
            
            
        }
    }
}
