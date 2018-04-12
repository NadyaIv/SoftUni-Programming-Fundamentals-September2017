using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal[] zones = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            int[] checkpoints= Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Select(x => Math.Abs(x)).ToArray();
            var result = new Dictionary<string,Dictionary<decimal,int>>();
            if (name.Length != 0)
            {
                foreach (var item in name)
                {

                    decimal fuel = (int)(item[0]);
                    for (int i = 0; i < zones.Length; i++)
                    {
                        if (checkpoints.Contains(i))
                        {
                            fuel += zones[i];
                        }
                        else
                        {
                            fuel -= zones[i];
                        }
                        if (fuel <= 0)
                        {
                            Console.WriteLine(item + " - reached " + i);
                            break;
                        }
                    }
                    if(fuel>0)
                    {
                        Console.WriteLine("{0} - fuel left {1:f2}", item, fuel);
                    }
                  
                }
            }
            
        }
    }
}
