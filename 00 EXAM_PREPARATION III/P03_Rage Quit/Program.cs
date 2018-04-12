using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string inputline = Console.ReadLine();
            string pattern = @"(\D+)(\d+)+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputline);
            int n = matches.Count;

            foreach (Match match in matches)
            {

                string symbol = match.Groups[1].Value.ToUpper();
                
                int num = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < num; i++)
                {
                    result.Append(symbol);
                    
                }
              

            }
            
          
            int unique = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", unique);
            Console.WriteLine(result);
        }     
    }
}
