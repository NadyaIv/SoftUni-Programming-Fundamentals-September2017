using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int count = 0;
            bool ismatch = false;
            int last = numbers.Last();
            numbers.RemoveAt(numbers.Count - 1);
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i] );
            }

            //for (int i = 0; i < result.Count; i++)
            //{

            //    if (result[i] == 0 && last == i)
            //    {
            //        foreach (var item in result)
            //        {
            //            Console.Write(item + " ");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine(count);
            //        return;
            //    }
            //}
            while (true)
            {
                
                for (int i = 0; i < result.Count; i++)
                {
                    result[i]--;
                }
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == 0 && last == i)
                    {

                        Console.WriteLine(string.Join(" ", result));
                        Console.WriteLine(count);
                        return;
                    }
                }
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == 0)
                    {
                        result[i] = numbers[i];
                    }
                }
                    
                
                
                last = int.Parse(Console.ReadLine());
                count++;

            }
            Console.WriteLine(string.Join(" ",result));
            Console.WriteLine(count);
        }
    }
}
