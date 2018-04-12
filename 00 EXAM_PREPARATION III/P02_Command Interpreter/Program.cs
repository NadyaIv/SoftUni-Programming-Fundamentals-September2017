using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            string comm = Console.ReadLine();
            while(comm!="end")
            { string[] line = comm.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                switch (command)
                {
                    case "reverse":
                        int start = int.Parse(line[2]);
                        int count= int.Parse(line[4]);
                        if(start <0 || start>=input.Count || count<0 || (count+start)> input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                           
                        }
                            result = input.Skip(start).Take(count).ToList();
                            result.Reverse();
                            input.RemoveRange(start, count);
                            input.InsertRange(start, result);
                        break;
                    case "sort":
                         start = int.Parse(line[2]);
                         count = int.Parse(line[4]);
                        if (start < 0 || (start + count) > input.Count || count < 0 || start >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                            
                        }
                            result = input.Skip(start).Take(count).ToList();
                            result.Sort();
                            input.RemoveRange(start, count);
                            input.InsertRange(start, result);
                        
                        break;
                    case "rollLeft":
                        count = int.Parse(line[1]);
                        if(count<0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                            
                        }
                       
                            int number = count % input.Count();
                            result = input.Take(number).ToList();
                            input.RemoveRange(0, number);
                            input.InsertRange(input.Count, result);
                        
                        break;
                    case "rollRight":
                        count = int.Parse(line[1]);
                        
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                          
                        }
                        
                            number = count % input.Count();
                            result = input.Skip(input.Count - number).Take(number).ToList();
                            input.RemoveRange(input.Count - number, number);
                            input.InsertRange(0, result);
                        
                        break;
                    default: break;

                }
                comm = Console.ReadLine();
            }
            
             Console.Write("["+string.Join(", ",input) + "]");
            
        }
    }
}
