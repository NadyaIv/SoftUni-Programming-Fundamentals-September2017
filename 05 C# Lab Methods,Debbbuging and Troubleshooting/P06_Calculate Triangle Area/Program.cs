using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Calculate_Triangle_Area
{
    class Program
    {   static double AreaOfTreangle(double width,double height)
        {
            return width * height / 2;
        }
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h= double.Parse(Console.ReadLine());
            double area = AreaOfTreangle(w, h);
            Console.WriteLine(area);
        }
    }
}
