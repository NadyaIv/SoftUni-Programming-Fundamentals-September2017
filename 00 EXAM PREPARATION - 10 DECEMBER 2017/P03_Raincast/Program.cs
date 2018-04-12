using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternType = @"^Type: (Normal|Warning|Danger)$";
            Regex regexType = new Regex(patternType);
            string patternSource = @"^Source: ([a-zA-Z0-9]+)$";
            Regex regexSource = new Regex(patternSource);
            string patternForecast = @"^Forecast: ([^!,.?]+)$";
            Regex regexForecast = new Regex(patternForecast);
            List<string> result = new List<string>();
            bool ismatch = true;
            bool issource = true;
            bool isforecast = true;
            string one = "";
            string two = "";
            string three = "";
            while (input!="Davai Emo")
            {
               
                if (regexType.IsMatch(input) && ismatch==true && issource==true)
                {
                    Match matchone = regexType.Match(input);
                     one = matchone.Groups[1].Value;
                    ismatch = false;
                    //string input2 = Console.ReadLine();
                    //while (input2 != "Davai Emo" && regexSource.IsMatch(input2))
                    //{
                    //        Match matchtwo = regexSource.Match(input2);
                    //        string input3 = Console.ReadLine();
                    //        while (input3 != "Davai Emo" && regexForecast.IsMatch(input3))
                    //        {
                    //                Match matchthree = regexForecast.Match(input3);
                    //                string results = "(" + matchone.Groups[1].Value + ") " + matchtwo.Groups[1] + " ~ " + matchthree.Groups[1];
                    //                result.Add(results);
                    //        input3 = Console.ReadLine();
                    //        }
                           
                    //    input2 = Console.ReadLine();
                    //}
                   
                }
                if(regexSource.IsMatch(input) && ismatch==false && issource==true)
                {
                    ismatch = true;
                    Match matchtwo = regexSource.Match(input);
                     two = matchtwo.Groups[1].Value;
                    issource = false;
                }
                if (regexForecast.IsMatch(input) && issource==false )
                {
                    issource = true;
                    Match matchthree = regexForecast.Match(input);
                     three = matchthree.Groups[1].Value;
                    isforecast = false;
                    
                }
                if(isforecast==false)
                {
                    isforecast = true;
                    string results = "(" + one + ") " + three + " ~ " +two;
                    result.Add(results);
                }
                input = Console.ReadLine();
            }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            
        }
    }
}
