using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternHealth = @"([^0-9\+\-\*\/\.])";
            string patternDamage = @"(([+-])?([0-9]+)(\.[0-9]+)?)";
            string patternMultyply = @"(\*)";
            string patternDivide = @"(\/)";
            Regex regexHealth = new Regex(patternHealth);
            Regex regexDamage = new Regex(patternDamage);
            Regex regexMultyply = new Regex(patternMultyply);
            Regex regexDivide = new Regex(patternDivide);
            long health = 0;
            decimal damage = 0;
            string[] input = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            var resultnew = new Dictionary<string, Dictionary<long,decimal>>();
            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection matchHealth = regexHealth.Matches(input[i]);
                foreach (Match item in matchHealth)
                {
                  
                    char letter =(char.Parse)(item.Groups[1].Value);
                    health +=letter;
                         
                }
                MatchCollection matchDamage = regexDamage.Matches(input[i]);
                foreach (Match item in matchDamage)
                { 
                    decimal damageone = decimal.Parse(item.Groups[1].Value);
                    damage += damageone;
                 
                }
                MatchCollection matchMulty = regexMultyply.Matches(input[i]);
                decimal countMulty =( decimal)Math.Pow(2,matchMulty.Count);
                MatchCollection matchDivide = regexDivide.Matches(input[i]);
                decimal countDivide = (decimal)Math.Pow(2,matchDivide.Count);
                 damage= damage * countMulty / countDivide;
                if(!resultnew.ContainsKey(input[i]))
                {
                    resultnew.Add(input[i], new Dictionary<long, decimal>());
                   
                }
                resultnew[input[i]].Add(health, damage);
               health = 0;
               damage = 0;
            }
            foreach (var item in resultnew.OrderBy(x=>x.Key))
            {
                foreach (var items in item.Value)
                {
                    string result = $"{item.Key} - {items.Key} health, {items.Value:f2} damage";
                    Console.WriteLine(result);

                }  
            }
        }
    }
}
