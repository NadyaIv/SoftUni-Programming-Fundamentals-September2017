using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;
            input.Sort();
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i <input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }

                }
                result[input[i]] = count;
                i = i + count-1;
                count = 0;
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}
