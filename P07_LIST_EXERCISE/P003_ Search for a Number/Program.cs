using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P003__Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstnumber = arr[0];
            int secondnumber = arr[1];
            int thirdnumber = arr[2];
            List<int> result = input.Take(firstnumber).ToList();
            List<int> resulttwo = result.Skip(secondnumber).ToList();
            if (resulttwo.Contains(thirdnumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
