using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var customers = new Dictionary<string, List<int>>();
            var flights = new List<int>();
            while(input!= "I believe I can fly!")
            {
                List<string> inputs =input.Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries).ToList();
                if(!(inputs[1] == "=" && inputs.Count == 3))
                {
                    string name = inputs[0];
                    if(!customers.ContainsKey(name))
                    {
                        customers.Add(name, new List<int>());
                     
                    }
                   flights = inputs.Skip(1).Select(int.Parse).ToList();
                    customers[name].AddRange(flights);
                    
                   
                }
                else
                {
                    string name = inputs[0];
                    string secondname = inputs[2];
                    //customers.Remove(name);
                    customers[name] =new List<int>( customers[secondname]);
                    //foreach (var item in customers)
                    //{
                    //    if(item.Key==secondname)
                    //    {
                    //        customers[name]
                    //    }
                              
                    
                }
                input = Console.ReadLine();
            }
           
                foreach (var item in customers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value))
                {
                    string fligth = String.Join(", ", item.Value.OrderBy(x => x));
                    Console.WriteLine("#{0} ::: {1}", item.Key, fligth);

                }
            
            
        }
    }
}
