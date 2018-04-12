using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,List<string>> result = new Dictionary<string, List<string>>();
            string evolution = "";
            while(input!= "wubbalubbadubdub")
            {
                string[] line = input.Split(new string[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(line.Length==3)
                {
                    string pokemonName = line[0];
                    string evolutionType = line[1];
                    int evolutionIndex = int.Parse(line[2]);
                    evolution = evolutionType + " <-> " + evolutionIndex;
                    if(!result.ContainsKey(pokemonName))
                    {
                        result.Add(pokemonName,new List<string>());
                    }
                    
                    result[pokemonName].Add(evolution);
                   
                }
                if(line.Length==1)
                {
                    string pokemonName = line[0];
                    if(result.ContainsKey(pokemonName))
                    {
                        foreach (var item in result)
                        {  
                            if(item.Key==pokemonName)
                            {
                                Console.WriteLine($"# {item.Key}");
                                foreach (var items in item.Value)
                                {
                                    Console.WriteLine(items);
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"# {item.Key}");
                foreach (var items in item.Value.OrderByDescending(x=>long.Parse(x.Split().Last())))
                {
                    Console.WriteLine(items);
                }
            }
        }
    }
}
