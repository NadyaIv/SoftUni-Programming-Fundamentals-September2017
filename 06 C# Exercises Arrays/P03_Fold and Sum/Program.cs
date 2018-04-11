using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] firstk = new int[2 * k];
            int[] middlek = new int[2*k];
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                firstk[i] = arr[k-i-1];
            }
            for (int i = k; i<2*k ;i++)
            {
                
                firstk[i]=arr[arr.Length-1-count];
                count += 1;
            }
            for (int i = k; i <3*k;  i++)
            {
                middlek[i-k] = arr[i];
            }
            
            int[] sum = new int[2*k];
            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = firstk[i] + middlek[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
