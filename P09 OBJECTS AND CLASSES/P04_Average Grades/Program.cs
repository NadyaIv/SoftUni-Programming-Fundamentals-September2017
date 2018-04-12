using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Average_Grades
{ class Student
    {
        public string name { get; set; }
        public List<double> grade { get; set; }
        public double avergrade { get; set; }
    }
        class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {

                string stud = Console.ReadLine();
                double avergrades = 0;
                List<string> student = new List<string>();
                student = stud.Split().ToList();
                List<double> grade = new List<double>();

                for (int j = 1; j < student.Count; j++)
                {
                    avergrades += double.Parse(student[j]);

                }
                avergrades = avergrades / (student.Count - 1);
                Student newstudent = new Student { name = student[0], grade = grade, avergrade = avergrades };
                students.Add(newstudent);
                
            }
            students = students.Where(s => s.avergrade >= 5.00).OrderBy(s => s.name).ThenByDescending(s => s.avergrade).ToList();
            foreach (var s in students)
            {
                Console.WriteLine($"{s.name} -> {s.avergrade:F2}");
            }
        }
    }
}
