using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
           List<long> numbers = Console.ReadLine().Split(new string[] { " "},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
           List<long> currlist = new List<long>();
            int count = 0;
            long indexes = 0;
            string input = Console.ReadLine();
            while(input!="end")
            {
                string[] line = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                switch(command)
                {
                    case "exchange":
                        int index = int.Parse(line[1]);
                        if(index<0 || index>=numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                            currlist = numbers.Skip(index + 1).ToList();
                            count = numbers.Count - index - 1;
                            numbers.RemoveRange(index + 1, count);
                            numbers.InsertRange(0, currlist);

                        }
                        break;
                    case "max":
                        
                        if(line[1]=="even")
                        {
                            int counts = numbers.Where(x => x % 2 == 0).Count();
                            if (counts == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                long even = numbers.Where(x => x % 2 == 0).Max();
                                indexes = numbers.LastIndexOf(even);
                                Console.WriteLine(indexes);
                            }
                            
                            break;
                        }
                        if (line[1]=="odd")
                        {
                            int counts = numbers.Where(x => x % 2 != 0).Count();
                            if (counts == 0)
                            {
                                Console.WriteLine("No matches");
                            }else
                            {
                                long odd = numbers.Where(x => x % 2 != 0).Max();
                                index = numbers.LastIndexOf(odd);
                                Console.WriteLine(index);
                            }
                            break;

                        }
                        break;
                    case "min":
                        if (line[1] == "even")
                        { 
                            int counts = numbers.Where(x => x % 2 == 0).Count();
                            if (counts == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                long even = numbers.Where(x => x % 2 == 0).Min();
                                index = numbers.LastIndexOf(even);
                                Console.WriteLine(index);
                            }     
                        }
                        else if (line[1] == "odd")
                        {
                            
                            int counts = numbers.Where(x => x % 2 != 0).Count();
                            if(counts==0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                long odd = numbers.Where(x => x % 2 != 0).Min();
                                index = numbers.LastIndexOf(odd);
                                Console.WriteLine(index);
                            }
                        }
                        break;
                    case "first":
                        if(line[2]=="even")
                        {
                            count = int.Parse(line[1]);
                            if(count>numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }else
                            {
                                currlist = numbers.Where(x => x % 2 == 0).ToList();
                                if(currlist.Count>count)
                                {
                                    currlist = currlist.Take(count).ToList();
                                }
                                Console.WriteLine("[" + string.Join(", ", currlist) + "]");
                            }
                        }
                        if (line[2] == "odd")
                        {
                            count = int.Parse(line[1]);
                            if(count>numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                currlist = numbers.Where(x => x % 2 != 0).ToList();
                                if (currlist.Count > count)
                                {
                                    currlist = currlist.Take(count).ToList();
                                }
                                Console.WriteLine("[" + string.Join(", ", currlist) + "]");
                            }
                        }
                        break;
                    case "last":
                        if (line[2] == "even")
                        {
                            count = int.Parse(line[1]);
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                currlist = numbers.Where(x => x % 2 == 0).ToList();
                                if (currlist.Count > count)
                                {
                                    currlist= currlist.Skip(currlist.Count-count).ToList();
                                }
                                Console.WriteLine("[" + string.Join(", ",currlist) + "]");
                            }
                        }
                        else if (line[2] == "odd")
                        {
                            count = int.Parse(line[1]);
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                currlist = numbers.Where(x => x % 2 != 0).ToList();
                                if (currlist.Count > count)
                                {
                                    currlist = currlist.Skip(currlist.Count-count).ToList();
                                }
                                Console.WriteLine("[" + string.Join(", ", currlist) + "]");
                            }
                        }
                        break;

                    default: break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");   
        }
    }
}
