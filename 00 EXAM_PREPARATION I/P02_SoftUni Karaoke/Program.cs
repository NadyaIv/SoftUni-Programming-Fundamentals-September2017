using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] {" ","," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
            Dictionary<string,List<string>> result = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while(input!="dawn")
            {
                List<string> lines = input.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).Select(x =>x.Trim()).ToList();
                string name = lines[0];
                string song = lines[1];
                string award = lines[2];
                if(names.Contains(name) && songs.Contains(song))
                { if(!result.ContainsKey(name))
                    {
                        result.Add(name, new List<string>());
                    }
                    result[name].Add(award);
                }
                input = Console.ReadLine();
            }
            if(result.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var item in result.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key + ": " + item.Value.Distinct().Count() + " awards");
                foreach (var items in result[item.Key].Distinct().OrderBy(x=>x))
                {
                    Console.WriteLine("--" + items);
                }
            }

        }
    }
}
