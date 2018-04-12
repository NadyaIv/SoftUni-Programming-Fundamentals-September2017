using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            while(numbers.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
                if(index<0)
                {
                    result.Add(numbers[0]);
                    int numIndex = numbers[0];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <=numIndex)
                        {
                            numbers[i] = numbers[i] + numIndex;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - numIndex;
                        }
                    }
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count-1]);
                }else if(index>numbers.Count()-1)
                {
                    result.Add(numbers[numbers.Count - 1]);
                    int numIndex = numbers[numbers.Count - 1];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= numIndex)
                        {
                            numbers[i] = numbers[i] + numIndex;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - numIndex;
                        }
                    }
                    
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                   
                }else if(index>=0 && index<= numbers.Count() - 1)
                {
                    result.Add(numbers[index]);
                    int numIndex = numbers[index];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i]<=numIndex)
                        {
                            numbers[i] = numbers[i] + numIndex;
                        }
                        else
                        {
                            numbers[i] = numbers[i] - numIndex;
                        }
                    }
                    numbers.RemoveAt(index);
                }
            }
            long sum = result.Sum();
            Console.WriteLine(sum);
           
        }
    }
}
