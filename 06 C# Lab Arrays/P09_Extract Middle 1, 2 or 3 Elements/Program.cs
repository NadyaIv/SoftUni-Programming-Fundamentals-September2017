using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();
            string[] result=new string[3];
            int length = nums.Length;
            
            if(length==1)
            {
                result = new string[1];
                result[0] = nums[0];

            }
            if(length%2==0)
            {
                result = new string[2];
                result[0] = nums[length / 2-1];
                result[1] = nums[length / 2 ];
            }
            if(length % 2 != 0 && length!=1)
            {
                result = new string[3];
                result[0] = nums[length / 2-1];
                result[1] = nums[length / 2 ];
                result[2] = nums[length / 2 + 1];

            }
            Console.Write("{ ");
            for (int i = 0; i <result.Length; i++)
            {  if(i== result.Length - 1)
                Console.Write("{0}",result[i]);
                else
                {
                    Console.Write("{0}, ", result[i]);
                }
            }
            Console.Write(" }");
        }
    }
}
