using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Mentor_Group
{
    class User
    {
        public string name { get; set; }
        public List<DateTime> date { get; set; }
        public List<string> comment { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>();
            User student = new User { };
            string line = Console.ReadLine();
            while (line != "end of dates")
            {
                List<string> input = line.Split().ToList();
                string names = input[0];
                student = new User { };

                if (user.Any(c => c.name == names))
                {
                    User newStudent = user.Where(x => x.name == names).First();
                  
                    if (input.Count == 1)
                    {
                        continue;
                    }

                    string dat = input[1];
                    List<DateTime> datef = dat.Split(',').Select(x => DateTime.ParseExact(x, "dd/mm/yyyy", CultureInfo.InvariantCulture)).ToList();
                    newStudent.date.AddRange(datef);

                }

                if (input.Count == 1)
                {
                    student.name = names;
                    student.comment = new List<string>();
                    student.date = new List<DateTime>();
                }
                if (input.Count > 1)
                {
                    student.name = names;
                    student.date = new List<DateTime>();
                    string dat = input[1];
                    List<DateTime> datef = dat.Split(',').Select(x => DateTime.ParseExact(x, "dd/mm/yyyy", CultureInfo.InvariantCulture)).ToList();
                    student.date.AddRange(datef);
                    student.comment = new List<string>();
                }

                if (!user.Any(c => c.name == names))
                {
                    user.Add(student);
                }

                line = Console.ReadLine();

            }
            string lines = Console.ReadLine();
            while (lines != "end of comments")
            {

                List<string> inputs = lines.Split('-').ToList();
                string names = inputs[0];
                string commentss = inputs[1];

                student = new User { };
                //student.name = names;
                //student.comment= comments;
                foreach (var item in user)
                {
                    if (item.name == names)
                    {
                        item.comment.Add(commentss);
                    }

                }

                lines = Console.ReadLine();
            }

            foreach (var item in user.OrderBy(x => x.name))
            {
                Console.WriteLine(item.name);
                Console.WriteLine("Comments:");
                if (item.comment.Count > 0)
                {
                    foreach (var items in item.comment)
                    {
                        Console.WriteLine($"- {items}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (item.date.Count > 0)
                {
                    foreach (var items in item.date.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {items.ToString("dd/mm/yyyy")}");
                    }
                }
            }
        }
    }

}
