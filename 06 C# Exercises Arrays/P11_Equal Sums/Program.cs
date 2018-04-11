using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumleft = 0;
            int sumrigth = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                sumleft = 0;
                sumrigth = 0;
                for (int j = 0; j < i; j++)
                
                {
                    sumleft += numbers[j];
                }
                for (int k = i+1; k < numbers.Length; k++)
                {
                    sumrigth += numbers[k];
                }
                if (sumleft == sumrigth)
                {
                    
                    Console.WriteLine(i);
                    return;
                }
                
                       
            }
            
             Console.WriteLine("no");
            
        }
    }
}
