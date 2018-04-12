using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Regex.Escape(Console.ReadLine());
            var teamsGoals = new Dictionary<string,long>();
            var teamsPoint = new Dictionary<string,long>();
            string pattern = $"(?<={key})([a-zA-Z]*)(?={key})";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            string firstteam = "";
            string secondteam = "";
            while (input!="final")
            {
                string[] lines = input.Split(new string[] { ":"," "},StringSplitOptions.RemoveEmptyEntries);
              
                
               long scoreFirstTeam = long.Parse(lines[lines.Length-2]);
               long scoreSecondTeam = long.Parse(lines[lines.Length-1]);
                
                int counts = 0;
                MatchCollection match = regex.Matches(input);
                foreach (Match item in match)
                {
                    string team = item.Groups[1].Value.ToUpper();
                    char[] c = team.ToCharArray();
                    Array.Reverse(c);
                    team = new string(c);
                    counts++;
                    if (counts == 1)
                    {
                        firstteam = team;
                    }
                    else
                    {
                        secondteam = team;
                    }
                }
                if (!teamsGoals.ContainsKey(firstteam))
                    {
                        teamsGoals.Add(firstteam, 0);

                    }

                    teamsGoals[firstteam] += scoreFirstTeam;


                    if (!teamsGoals.ContainsKey(secondteam))
                    {
                        teamsGoals.Add(secondteam, 0);

                    }

                    teamsGoals[secondteam] += scoreSecondTeam;

                    if (!teamsPoint.ContainsKey(firstteam))
                    {
                        teamsPoint.Add(firstteam, 0);
                    }
                    if (!teamsPoint.ContainsKey(secondteam))
                    {
                        teamsPoint.Add(secondteam, 0);
                    }
                    if (scoreFirstTeam > scoreSecondTeam)
                    {
                        teamsPoint[firstteam] += 3;
                    }
                    if (scoreFirstTeam == scoreSecondTeam)
                    {
                        teamsPoint[firstteam] += 1;
                        teamsPoint[secondteam] += 1;
                    }
                    if (scoreFirstTeam < scoreSecondTeam)
                    {
                        teamsPoint[secondteam] += 3;
                    }
                
                input = Console.ReadLine();
            }
            
                Console.WriteLine("League standings:");
                int count = 1;
                foreach (var item in teamsPoint.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {

                    Console.WriteLine(count + ". " + item.Key + " " + item.Value);
                    count++;
                }
                Console.WriteLine("Top 3 scored goals:");
                int numbers = 0;
                foreach (var item in teamsGoals.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine("- " + item.Key + " -> " + item.Value);
                    numbers++;
                    if (numbers == 3)
                    {
                    return;
                    }
                }
            }  
        }
    }

