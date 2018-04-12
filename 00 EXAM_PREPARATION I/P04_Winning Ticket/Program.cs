using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@{6,10})|(\#{6,10})|(\${6,10})|(\^{6,10})";
            bool isMatch = true;
            Regex regex = new Regex(pattern);
            string[] input = Console.ReadLine().Split(new string[] {" ","," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    int length = item.Length / 2;
                    string itemLeft = item.Substring(0, length);
                    string itemRight = item.Substring(length);
                    MatchCollection matchLeft = regex.Matches(itemLeft);
                    MatchCollection matchRight = regex.Matches(itemRight);
                    if (matchLeft.Count == 0 || matchRight.Count == 0)
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", item);
                    }
                    else
                    {
                        foreach (Match items in matchLeft)
                        {
                            foreach (Match itemss in matchRight)
                            {
                                int count = items.Value.Count();
                                string simbol = items.Value.Substring(count - 1);
                                int countitemss = itemss.Value.Count();
                                string simbolitemss = itemss.Value.Substring(countitemss - 1);
                                int min = Math.Min(count, countitemss);
                                if (simbol == simbolitemss)
                                {
                                    isMatch = false;
                                    if (min == 10)
                                    {
                                        Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", item, simbol);
                                    }
                                    else
                                    {
                                        Console.WriteLine("ticket \"{0}\" - {2}{1}", item, simbol, min);
                                    }

                                }
                                if (isMatch)
                                {
                                    Console.WriteLine("ticket \"{0}\" - no match", item);
                                }
                                isMatch = true;
                            }
                        }
                       
                    }
                }
                
            }
        }
    }
}
