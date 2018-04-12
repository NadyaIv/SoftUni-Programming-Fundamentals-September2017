using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengtharray = int.Parse(Console.ReadLine());
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            long[] result = new long[lengtharray];
           long newindex = 0;
           
            
           for (int i = 0; i <indexes.Count; i++)
            {
                if (indexes[i]>=0 && indexes[i]<result.Length)
              {
                result[indexes[i]] = 1;
              }
               
            }

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] line = input.Split();
                long index = long.Parse(line[0]);
                string command = line[1];
                long flylength = long.Parse(line[2]);
                if (index >= 0 && index < result.Length && result[index]==1)
                {
                   
                        result[index] = 0;

                        if (command == "right")
                        {  
                                newindex = index + flylength;
                          
                            while (newindex < result.Length && newindex>=0)
                            {
                                if (result[newindex] == 1)
                                {
                                    newindex += flylength;
                                }else
                                {
                                    result[newindex] = 1;
                                break;
                                }
                                  
                            }
                        }
                        if (command == "left")
                        {   
                                 newindex = index - flylength;
                           
                            while (newindex < result.Length && newindex >= 0)
                            {
                                if (result[newindex] == 1)
                                {
                                    newindex -= flylength;
                                }else
                                {
                                    result[newindex] = 1;
                                break;
                                }  
                            }
                        }
                    }
                
                input = Console.ReadLine();
            }
            if(result.Length>0)
            {
                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }
           
        }
    }
}
