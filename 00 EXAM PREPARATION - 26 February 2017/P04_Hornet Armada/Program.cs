using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var activity = new Dictionary<string, long>();
            var legion = new Dictionary<string, Dictionary<string, long>>();
            var result = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { ":","=","->"," "},StringSplitOptions.RemoveEmptyEntries).ToArray();
                long legionActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soliderType = input[2];
                long soliderCount = long.Parse(input[3]);
                if(!legion.ContainsKey(legionName))
                {
                    legion.Add(legionName, new Dictionary<string, long>());
                }
                if(!legion[legionName].ContainsKey(soliderType))
                {
                    legion[legionName].Add(soliderType, 0);
                }
                legion[legionName][soliderType] += soliderCount;
                if(!activity.ContainsKey(legionName))
                {
                    activity.Add(legionName, 0);
                }
                if(activity[legionName]<legionActivity)
                {
                    activity[legionName] = legionActivity;
                }
            }
            string[] line = Console.ReadLine().Split('\\').ToArray();
            
            if(line.Length>1)
            {
                foreach (var item in legion)
                {
                    foreach (var items in item.Value)
                    {
                        if(line[1]==items.Key)
                        {
                            if(activity[item.Key]<=long.Parse(line[0]))
                            {
                                if(result.ContainsKey(item.Key))
                                {
                                    result.Add(item.Key, 0);
                                }
                                result[item.Key] = items.Value;
                            }
                        }
                               
                    }
                }
                foreach (var item in result.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }else  
            {

                foreach (var item in activity.OrderByDescending(x=>x.Value))
                {
                    if(legion[item.Key].ContainsKey(line[0]))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }

                }
                
            }
            
        }
    }
}
