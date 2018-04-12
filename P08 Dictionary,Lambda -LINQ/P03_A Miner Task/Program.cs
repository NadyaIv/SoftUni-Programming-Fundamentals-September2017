using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            
            Dictionary<string, long> source = new Dictionary<string, long>();

            while (input!="stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (source.ContainsKey(input))
                {
                    source[input] += quantity;
                    
                }
                else
                {
                    source.Add(input, quantity);
                   
                }
                input = Console.ReadLine();
               

            }
            if (input == "stop")
            {
                foreach (var item in source)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }


            }
        }
    }
}
