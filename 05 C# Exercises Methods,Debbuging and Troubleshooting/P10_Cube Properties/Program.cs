using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Cube_Properties
{
    class Program
    { static double FaceDiagonals(double s)
        {
            double facediagonals = Math.Sqrt(2 *Math.Pow( s,2));
            return facediagonals;
        }
        static double SpaceDiagonals(double d)
        {
            double spacediagonals = Math.Sqrt(3 * Math.Pow(d, 2));
            return spacediagonals;
        }
        static double VolumeCube(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }
        static double SurfaceCube(double side)
        {
            double surface =6 * Math.Pow(side, 2);
            return surface;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            if (name == "face")
            { 
                Console.WriteLine($"{FaceDiagonals(side):f2}");
            }
            else if (name == "space")
            {
                Console.WriteLine(($"{SpaceDiagonals(side):f2}"));
            }
            else if (name == "volume")
            {
                Console.WriteLine($"{VolumeCube(side):f2}");
            }
            else if (name == "area")
            {

                Console.WriteLine($"{SurfaceCube(side):F2}");
            }
        }
    }
}
