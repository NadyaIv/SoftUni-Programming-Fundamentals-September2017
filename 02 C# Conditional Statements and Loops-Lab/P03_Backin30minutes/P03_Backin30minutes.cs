using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Backin30minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes>=60)
            {
                minutes -= 60;
                hours += 1;
                if ( hours == 24)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
