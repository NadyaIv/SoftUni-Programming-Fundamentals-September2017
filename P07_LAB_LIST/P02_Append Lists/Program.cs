using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            List<int> result = new List<int>();
            List<int> nums = new List<int>();
            foreach (var item in input)
            {
                result = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                foreach (var num in result)
                {
                    nums.Add(num);
                }

            }
            foreach (var item in nums)
            {
                Console.Write(item+" ");
            }

        }
    }
}
