using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "Such a great product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";
            
            string[] events ={ "Now I feel good.", "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!" };
            
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int ph = rnd.Next(0, phrases.Length);
                int ev = rnd.Next(0, events.Length);
                int au = rnd.Next(0, authors.Length);
                int ci = rnd.Next(0, cities.Length);
                Console.WriteLine("{0} {1} {2} - {3}",phrases[ph],events[ev],authors[au],cities[ci]);
            }
           

        }
    }
}
