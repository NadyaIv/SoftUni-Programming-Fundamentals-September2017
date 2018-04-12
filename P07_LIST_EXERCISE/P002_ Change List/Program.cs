using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002__Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string lines = Console.ReadLine();
            int element =0;
         


            while (true)
            {
                
                List<string> line = lines.Split(' ').ToList();
                string command = line[0];
                if (command == "Delete")
                {
                    element = (int.Parse)(line[1]);
                    for (int i=0; i < input.Count; i++)
                    {
                        if (input[i]==element)
                        {
                            input.RemoveAt(i);
                            i--;
                        }
                         
                    }

                }
                if (command == "Insert")
                {
                    element = (int.Parse)(line[1]);
                   int position = (int.Parse)(line[2]);
                    input.Insert(position, element);

                }
                if (command == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write(input[i]+" ");
                        }

                    }
                    break;
                }
                if (command == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write(input[i]+" ");
                        }

                    }
                    break;
                }
             
                lines = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
