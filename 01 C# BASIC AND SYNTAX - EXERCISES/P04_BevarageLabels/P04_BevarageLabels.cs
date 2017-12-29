using System;


namespace P04_BevarageLabels
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double energycontent = energy * volume / 100;
            double sugarcontent = sugar * volume / 100;
            Console.WriteLine(volume+"ml "+ name+":");
            Console.WriteLine(energycontent+"kcal, "+sugarcontent+"g sugars");


        }
    }
}
