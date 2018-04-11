using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] nums = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                nums[i] = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",numbers[i],nums[i]);
            }


        }
    }
}
