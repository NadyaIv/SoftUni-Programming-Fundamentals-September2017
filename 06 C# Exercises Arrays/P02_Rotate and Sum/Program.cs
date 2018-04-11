using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Rotate_and_Sum
{
    class Program
    {
        static void SwapElement(int[] arr)
        {
            var last = arr[arr.Length - 1];

            for (int i = arr.Length-1; i > 0; i--)
            {
                arr[i] = arr[i - 1];


            }
            arr[0] = last;
        }
        
    
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int j = 0; j < n; j++)
            {
                SwapElement(nums);
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = sum[i] + nums[i];
                }
               

            }


            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
