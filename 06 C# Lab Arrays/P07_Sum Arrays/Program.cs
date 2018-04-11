using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] num2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len1 = num1.Length;
            int len2 = num2.Length;
            int length = Math.Max(len1, len2);
            int[] sum = new int[length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i%length] = num1[i % len1] + num2[i % len2];
            }
            foreach (var item in sum)
            {
                Console.Write(item+" ");
            }
        }
    }
}
