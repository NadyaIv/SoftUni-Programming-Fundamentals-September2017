using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03__Intersection_of_Circles
{
    class Program
    {
        static double CalcDist(Point C1, Point C2)
        {
            int DeltaX = C1.x - C2.x;
            int DeltaY = C1.y - C2.y;
            double distance = Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
            return distance;
        }
        static void Main(string[] args)
        {   
            string circleone = Console.ReadLine();
            string circletwo = Console.ReadLine();
            int[] cione = circleone.Split().Select(int.Parse).ToArray();
            int[] citwo = circletwo.Split().Select(int.Parse).ToArray();

            Point C1 = new Point { x = cione[0], y = cione[1], r = cione[2] };
            Point C2 = new Point { x = citwo[0], y =citwo[1], r = citwo[2]};
            double distance =CalcDist(C1, C2);
            int rdist = C1.r + C2.r;
           
            if (rdist>=distance)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
    

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
    }
}
