using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine().Split(new string[] {" ",",",";",":",".","!","(",")","\"","\'","\\",",","/","[","]" },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> other = new List<string>();
            int lowercount = 0;
            int uppercount = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                string word = inputs[i];
                for (int j = 0; j < word.Length; j++)
                { 
                    if((int)word[j]>=97 && (int)word[j]<=122)
                    {
                        lowercount++;
                    }
                    if ((int)word[j] >= 65 && (int)word[j] <= 90)
                    {
                        uppercount++;
                    }
                }
                if(lowercount==word.Length)
                {
                    lowercase.Add(word);
                }
                else if(uppercount== word.Length)
                {
                    uppercase.Add(word);
                }
                else
                {
                    other.Add(word);
                }
                lowercount = 0;
                uppercount = 0;
            }
            Console.Write("Lower-case: ");
            for (int i = 0; i < lowercase.Count; i++)
            {
                if(i==(lowercase.Count-1))
                {
                    Console.Write(lowercase[i]);
                }
                else
                {
                    Console.Write(lowercase[i]+", ");
                }
            }
            Console.WriteLine();
            Console.Write("Mixed-case: ");
            for (int i = 0; i < other.Count; i++)
            {
                if (i == other.Count - 1)
                {
                    Console.Write(other[i]);
                }
                else
                {
                    Console.Write(other[i] + ", ");
                }
            }
            Console.WriteLine();
            Console.Write("Upper-case: ");
            for (int i = 0; i < uppercase.Count; i++)
            {
                if (i == uppercase.Count - 1)
                {
                    Console.Write(uppercase[i]);
                }
                else
                {
                    Console.Write(uppercase[i] + ", ");
                }
            }
        }
    }
}
