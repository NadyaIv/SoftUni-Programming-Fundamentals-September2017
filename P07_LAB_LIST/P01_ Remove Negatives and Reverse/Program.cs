using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01__Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] >= 0)
                {
                    result.Add(nums[i]);
                }
            }
            result.Reverse();
            foreach (var num in result)
            {
                Console.Write(num+" ");
            }
            if(result.Count==0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
