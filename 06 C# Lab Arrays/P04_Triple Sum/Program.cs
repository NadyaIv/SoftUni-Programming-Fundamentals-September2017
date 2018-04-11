using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = 0;
            int b = 0;
            int c = 0;
            bool isCont = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    a = nums[i];
                    b = nums[j];
                    c = a + b;
                   if( nums.Contains(c)==true)
                    {
                        isCont = true;
                        Console.WriteLine("{0} + {1} == {2}",a,b,c);
                    }
                }
            }
            if(isCont==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
