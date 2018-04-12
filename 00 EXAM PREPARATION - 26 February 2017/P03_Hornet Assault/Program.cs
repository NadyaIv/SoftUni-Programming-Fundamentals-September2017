using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehieves = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();




            for (int i = 0; i < beehieves.Count; i++)
            {
                if (hornets.Count != 0 )
                {
                    if (beehieves[i] < hornets.Sum())
                    {
                        beehieves.RemoveAt(i);
                        i--;
                    }
                    else if (beehieves[i] == hornets.Sum())
                    {
                        beehieves.RemoveAt(i);
                        hornets.RemoveAt(0);
                        i--;
                    }
                    else if (beehieves[i] > hornets.Sum())
                    {
                        beehieves[i] -= hornets.Sum();
                        hornets.RemoveAt(0);
                    }
                }
            }

            if (beehieves.Count != 0)
            {
                foreach (var item in beehieves)
                {
                    Console.Write(item + " ");
                }
            }
            else if (hornets.Count != 0)
            {
                foreach (var item in hornets)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
