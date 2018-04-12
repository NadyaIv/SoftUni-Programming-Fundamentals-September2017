using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Average_Grade_Ivo_Hristov
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releasedate { get; set; }
        public long ISBNnumber { get; set; }
        public double price { get; set; }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                List<string> lines = line.Split().ToList();
                Book book = new Book()
                {
                    title = lines[0],
                    author = lines[1],
                    publisher = lines[2],
                    releasedate = DateTime.ParseExact(lines[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNnumber = long.Parse(lines[4]),
                    price = double.Parse(lines[5]),
                };
                books.Add(book);
            }

            List<Book> newbook= new List<Book>();
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var item in books)
            {
                if (item.releasedate > date)
                {
                    newbook.Add(item);
                }
            }

            newbook = newbook.OrderBy(x => x.releasedate).ThenBy(x => x.title).ToList() ;
            foreach (var item in newbook)
            {
                Console.WriteLine($"{item.title} -> {item.releasedate:dd.MM.yyyy}");
            }
        }
    }
}
