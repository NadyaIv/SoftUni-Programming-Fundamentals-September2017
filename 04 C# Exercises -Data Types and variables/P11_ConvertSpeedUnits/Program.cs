using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters= int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float timehours = hours + minutes / 60F + seconds / 3600F;
            float timesec = 3600F * hours + 60F * minutes + seconds;
            float meterpersec = (float)meters / timesec;
            float kmperhour = (meters / 1000F) / timehours;
            float mileperhour = (meters/1609F) / timehours;
            Console.WriteLine(meterpersec);
            Console.WriteLine(kmperhour);
            Console.WriteLine(mileperhour);
        }
    }
}
