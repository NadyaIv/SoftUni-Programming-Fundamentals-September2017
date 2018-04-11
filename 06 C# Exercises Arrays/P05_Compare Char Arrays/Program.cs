using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {    
            string[] wordsone = Console.ReadLine().Split(' ').ToArray();
            string wordsonechar = String.Join("", wordsone);
            string[] wordstwo = Console.ReadLine().Split(' ').ToArray();
            string wordstwochar = String.Join("", wordstwo);
            int length = Math.Min(wordsone.Length, wordstwo.Length);
            for (int i = 0; i < length; i++)
            {
                if (wordsonechar[i] < wordstwochar[i])
                {
                    Console.WriteLine(wordsonechar);
                    Console.WriteLine(wordstwochar);
                    break;
                }
                else if(wordsonechar[i] > wordstwochar[i])
                {
                    Console.WriteLine(wordstwochar);
                    Console.WriteLine(wordsonechar);
                    break;
                }
                else
                {
                   if(wordsone.Length<=wordstwo.Length)
                    {
                        Console.WriteLine(wordsonechar);
                        Console.WriteLine(wordstwochar);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(wordstwochar);
                        Console.WriteLine(wordsonechar);
                        break;
                    }
                }
                

            }
            
            
        }
    }
}
