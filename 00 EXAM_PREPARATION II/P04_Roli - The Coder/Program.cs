using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> participiant = new Dictionary<string, string>();
            var resultes = new Dictionary<string, List<string>>();
            while (input != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    string[] line = input.Split(new string[] { "#", "@", " " }, StringSplitOptions.RemoveEmptyEntries);
                    List<string> participiants = new List<string>();
                    string id = line[0];
                    string eventName = line[1];

                    if (line.Length > 2)
                    {
                        participiants = line.Skip(2).ToList();
                    }

                    if (!participiant.ContainsKey(id))
                    {
                        participiant.Add(id, eventName);
                        resultes.Add(eventName, participiants);
                    }
                    else if (participiant[id]==eventName)
                    {
                        resultes[eventName].AddRange(participiants);
                    }

                }
                input = Console.ReadLine();
            }

            foreach (var item in resultes.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {

                Console.WriteLine(item.Key + " - " + item.Value.Distinct().Count());
                foreach (var items in item.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine($"@{items}");
                }


            }

        }
    }
}
