using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Geometry_Calculator
{
    class Program
    { static double Triangle(double side,double height)
        {
           
            double area = side * height / 2;
            return area;
        }
        static double Square(double side)
        {
            
            double area = side * side;
            return area;
        }
        static double AreaOfRectangle(double weight, double height)
        {
            double area = weight * height;
            return area;

        }
        static double AreaOfCircle( double radius)
        {
            
            double area = Math.PI*radius*radius;
            return area;
        }
        static void Main(string[] args)
        {
            string area = Console.ReadLine();
            if (area == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height= double.Parse(Console.ReadLine());
                Console.WriteLine($"{Triangle(side,height):f2}");
            }
            else if (area == "square")
            {

                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Square(side):f2}");
            }
            else if(area == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{AreaOfRectangle(side, height):f2}");
            }
            else if(area == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{AreaOfCircle(side):f2}");
            }
        }
    }
}
